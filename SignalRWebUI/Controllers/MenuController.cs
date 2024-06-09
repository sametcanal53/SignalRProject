using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.Baskets.Create;
using SignalRWebUI.Dtos.Products.Model;
using System.Text;

namespace SignalRWebUI.Controllers
{
    public class MenuController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public MenuController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:5353/api/Product/");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<GetProductDto>>(content);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddToBasket([FromBody] CreateBasketDto createBasketDto)
        {
            var client = _httpClientFactory.CreateClient();
            createBasketDto.Amount = 1;
            createBasketDto.State = true;
            createBasketDto.MenuTableId = 4;
            var content = new StringContent(JsonConvert.SerializeObject(createBasketDto), Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"https://localhost:5353/api/Basket", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(createBasketDto);
        }

    }
}
