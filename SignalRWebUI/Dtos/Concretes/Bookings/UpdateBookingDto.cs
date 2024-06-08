using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Bookings
{
    public class UpdateBookingDto : BookingDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
