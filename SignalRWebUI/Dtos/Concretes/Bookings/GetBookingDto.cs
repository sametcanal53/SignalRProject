using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Bookings
{
    public class GetBookingDto : BookingDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
