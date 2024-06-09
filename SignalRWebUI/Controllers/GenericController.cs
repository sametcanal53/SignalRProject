using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace SignalRWebUI.Controllers
{
    public class GenericController<TModel, TCreateDto, TUpdateDto> : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GenericController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public virtual async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:5353/api/{ControllerContext.ActionDescriptor.ControllerName}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<TModel>>(content);
                return View(result);
            }
            return View();
        }

        [HttpGet]
        public virtual async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public virtual async Task<IActionResult> Create(TCreateDto createDto)
        {
            var client = _httpClientFactory.CreateClient();
            var content = new StringContent(JsonConvert.SerializeObject(createDto), Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"https://localhost:5353/api/{ControllerContext.ActionDescriptor.ControllerName}", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public virtual async Task<IActionResult> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"https://localhost:5353/api/{ControllerContext.ActionDescriptor.ControllerName}/{id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public virtual async Task<IActionResult> Update(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:5353/api/{ControllerContext.ActionDescriptor.ControllerName}/{id}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<TUpdateDto>(content);
                return View(result);
            }
            return View();
        }

        [HttpPost]
        public virtual async Task<IActionResult> Update(TUpdateDto updateDto)
        {
            var client = _httpClientFactory.CreateClient();
            var content = new StringContent(JsonConvert.SerializeObject(updateDto), Encoding.UTF8, "application/json");
            var response = await client.PatchAsync($"https://localhost:5353/api/{ControllerContext.ActionDescriptor.ControllerName}", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
