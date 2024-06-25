using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.EntityLayer.Entities;
using SignalRWebUI.Dtos.Users;
using SignalRWebUI.Dtos.Users.Create;
using System.Text;

namespace SignalRWebUI.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly SignInManager<User> _signInManager;

        public AccountController(SignInManager<User> signInManager, IHttpClientFactory httpClientFactory)
        {
            _signInManager = signInManager;
            _httpClientFactory = httpClientFactory;
        }

        /*[HttpGet]
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
                return RedirectToAction("Login");
            }
            return View();
        }*/

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            /*var client = _httpClientFactory.CreateClient();
            var content = new StringContent(JsonConvert.SerializeObject(loginDto), Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"https://localhost:5353/api/{ControllerContext.ActionDescriptor.ControllerName}/Login", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Category");
            }
            return View();*/

            var result = await _signInManager.PasswordSignInAsync(loginDto.Username, loginDto.Password, loginDto.IsPersistent, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Category");
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
