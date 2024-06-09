using SignalRWebUI.Dtos.Bookings.Create;
using SignalRWebUI.Dtos.Bookings.Model;
using SignalRWebUI.Dtos.Bookings.Update;


namespace SignalRWebUI.Controllers
{
    public class BookingController : GenericController<GetBookingDto, CreateBookingDto, UpdateBookingDto>
    {
        public BookingController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
