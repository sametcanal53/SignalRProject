using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Bookings.Model
{
    public class GetBookingDto : BookingDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
