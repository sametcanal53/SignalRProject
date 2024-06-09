using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.Categories.Model;
using SignalRWebUI.Dtos.Products.Create;
using SignalRWebUI.Dtos.Products.Model;
using SignalRWebUI.Dtos.Products.Update;

namespace SignalRWebUI.Controllers
{
    public class ProductController : GenericController<GetProductDto, CreateProductDto, UpdateProductDto>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ProductController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        [HttpGet]
        public override async Task<IActionResult> Create()
        {
            await GetSelectListItems();
            return View();
        }

        [HttpGet]
        public override async Task<IActionResult> Update(int id)
        {
            await GetSelectListItems();
            return base.Update(id).Result;
        }

        // Private Methods
        private async Task GetSelectListItems()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:5353/api/Category");
            var content = await response.Content.ReadAsStringAsync();
            var categories = JsonConvert.DeserializeObject<List<GetCategoryDto>>(content);
            List<SelectListItem> selectListItems = (from category in categories
                                                    select new SelectListItem
                                                    {
                                                        Text = category.Name,
                                                        Value = category.Id.ToString()
                                                    }).ToList();
            ViewBag.Categories = selectListItems;
        }
    }
}
