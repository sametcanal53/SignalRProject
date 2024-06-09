using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.Bookings.Create;
using SignalRWebUI.Dtos.Bookings.Model;
using SignalRWebUI.Dtos.Bookings.Update;
using System.Net.Http;
using System.Text;

namespace SignalRWebUI.Controllers
{
    public class BookATableController : GenericController<GetBookingDto, CreateBookingDto, UpdateBookingDto>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BookATableController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public override async Task<IActionResult> Index() => base.Index().Result;

        [HttpPost]
        public async Task<IActionResult> Index(CreateBookingDto createBookingDto)
        {
            var client = _httpClientFactory.CreateClient();
            var content = new StringContent(JsonConvert.SerializeObject(createBookingDto), Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"https://localhost:5353/api/Booking", content);
            if (response.IsSuccessStatusCode)
            {
                Thread.Sleep(5000);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
