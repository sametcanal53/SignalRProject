using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.Users.Create;
using System.Text;

namespace SignalRWebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public UserController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(CreateUserDto createDto)
        {
            var client = _httpClientFactory.CreateClient();
            var content = new StringContent(JsonConvert.SerializeObject(createDto), Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"https://localhost:5353/api/{ControllerContext.ActionDescriptor.ControllerName}/Register", content);
            if (response.IsSuccessStatusCode)
            {
                Thread.Sleep(3000);
                return RedirectToAction("Register");
            }
            return View();
        }
    }
}
