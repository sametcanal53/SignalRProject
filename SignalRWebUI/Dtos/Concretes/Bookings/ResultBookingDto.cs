using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Bookings
{
    public class ResultBookingDto : BookingDto, IDto<int>
    {
        public int Id { get; set; }
    }
}

