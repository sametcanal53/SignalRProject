using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.MenuTables.Create;
using SignalRWebUI.Dtos.MenuTables.Model;
using SignalRWebUI.Dtos.MenuTables.Update;

namespace SignalRWebUI.Controllers
{
    public class MenuTableController : GenericController<GetMenuTableDto, CreateMenuTableDto, UpdateMenuTableDto>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public MenuTableController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> GetTablesByStatus()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:5353/api/{ControllerContext.ActionDescriptor.ControllerName}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<GetMenuTableDto>>(content);
                return View(result);
            }
            return View();
        }

    }
}
