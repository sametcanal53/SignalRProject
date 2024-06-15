using Microsoft.AspNetCore.Mvc;
using SignalR.Core.Enums;
using SignalRWebUI.Dtos.Bookings.Create;
using SignalRWebUI.Dtos.Bookings.Model;
using SignalRWebUI.Dtos.Bookings.Update;


namespace SignalRWebUI.Controllers
{
    public class BookingController : GenericController<GetBookingDto, CreateBookingDto, UpdateBookingDto>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BookingController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> BookingStatusApproved(int id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.PatchAsync($"https://localhost:5353/api/{ControllerContext.ActionDescriptor.ControllerName}/ChangeBookingStatus/" + id + $"/{EnumBookingStatus.Approved}", null);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> BookingStatusRejected(int id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.PatchAsync($"https://localhost:5353/api/{ControllerContext.ActionDescriptor.ControllerName}/ChangeBookingStatus/" + id + $"/{EnumBookingStatus.Rejected}", null);
            return RedirectToAction("Index");
        }
    }
}
