using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.Concretes.Features;

namespace SignalRWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultSliderComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultSliderComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:5353/api/Features/GetFeaturesWithFeatureDetails");
            var content = await response.Content.ReadAsStringAsync();
            var featureDetails = JsonConvert.DeserializeObject<List<ResultFeatureWithFeatureDetailDto>>(content);
            return View(featureDetails);
        }
    }
}
