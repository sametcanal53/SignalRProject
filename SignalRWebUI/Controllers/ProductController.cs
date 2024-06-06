using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.Concretes.Category;
using SignalRWebUI.Dtos.Concretes.Products;
using System.Net.Http;

namespace SignalRWebUI.Controllers
{
    public class ProductController : BaseController<ResultProductDto, CreateProductDto, UpdateProductDto>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ProductController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public override async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:5353/api/{ControllerContext.ActionDescriptor.ControllerName}/GetProductListWithCategory");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var categories = JsonConvert.DeserializeObject<List<ResultProductDto>>(content);
                return View(categories);
            }
            return View();
        }

        [HttpGet]
        public override async Task<IActionResult> Create()
        {
            GetSelecListItems();
            return View();
        }

        [HttpGet]
        public override async Task<IActionResult> Update(int id)
        {
            GetSelecListItems();
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:5353/api/{ControllerContext.ActionDescriptor.ControllerName}/{id}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var category = JsonConvert.DeserializeObject<UpdateProductDto>(content);
                return View(category);
            }
            return View();
        }

        private async void GetSelecListItems()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:5353/api/Category");
            var content = await response.Content.ReadAsStringAsync();
            var categories = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(content);
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
