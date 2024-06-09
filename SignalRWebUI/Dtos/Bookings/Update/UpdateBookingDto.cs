using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Bookings.Update
{
    public class UpdateBookingDto : BookingDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
