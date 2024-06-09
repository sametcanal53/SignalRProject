using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.FeatureDetails.Create;
using SignalRWebUI.Dtos.FeatureDetails.Model;
using SignalRWebUI.Dtos.FeatureDetails.Update;
using SignalRWebUI.Dtos.Features.Model;

namespace SignalRWebUI.Controllers
{
    public class FeatureDetailController : GenericController<GetFeatureDetailDto, CreateFeatureDetailDto, UpdateFeatureDetailDto>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public FeatureDetailController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
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
            var response = await client.GetAsync($"https://localhost:5353/api/Feature");
            var content = await response.Content.ReadAsStringAsync();
            var features = JsonConvert.DeserializeObject<List<GetFeatureDto>>(content);
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
