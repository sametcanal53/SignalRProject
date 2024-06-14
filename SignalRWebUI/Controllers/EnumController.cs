using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SignalRWebUI.Controllers
{
    public class EnumController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public EnumController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<Dictionary<int, string>> GetEnumValues(string enumType)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:5353/api/Enum/GetEnumValues?enumTypeName={enumType}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Dictionary<int, string>>(content);
            return result;
        }
    }
}
