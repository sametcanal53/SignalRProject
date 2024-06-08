using SignalRWebUI.Dtos.Concretes.Bookings;

namespace SignalRWebUI.Controllers
{
    public class BookingController : GenericController<ResultBookingDto, CreateBookingDto, UpdateBookingDto>
    {
        public BookingController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
