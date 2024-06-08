using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.Concretes.Features;

namespace SignalRWebUI.Controllers
{
    public class FeaturesController : GenericController<ResultFeatureDto, CreateFeatureDto, UpdateFeatureDto>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public FeaturesController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public override async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:5353/api/{ControllerContext.ActionDescriptor.ControllerName}/GetFeaturesWithFeatureDetails");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var features = JsonConvert.DeserializeObject<List<ResultFeatureWithFeatureDetailDto>>(content);
                return View(features);
            }
            return View();
        }

        [HttpGet]
        public override async Task<IActionResult> Create()
        {
            await GetSelecListItems();
            return View();
        }

        [HttpGet]
        public override async Task<IActionResult> Update(int id)
        {
            await GetSelecListItems();
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:5353/api/{ControllerContext.ActionDescriptor.ControllerName}/GetFeaturesWithFeatureDetails");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var feature = JsonConvert.DeserializeObject<UpdateFeatureDto>(content);
                return View(feature);
            }
            return View();
        }

        // Private Methods
        private async Task GetSelecListItems()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:5353/api/Features");
            var content = await response.Content.ReadAsStringAsync();
            var features = JsonConvert.DeserializeObject<List<ResultFeatureDto>>(content);
            List<SelectListItem> selectListItems = (from feature in features
                                                    select new SelectListItem
                                                    {
                                                        Text = feature.Name,
                                                        Value = feature.Id.ToString()
                                                    }).ToList();
            ViewBag.Features = selectListItems;
        }
    }
}
