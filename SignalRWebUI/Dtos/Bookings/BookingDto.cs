using SignalR.Core.Concretes;
using SignalR.Core.Enums;

namespace SignalRWebUI.Dtos.Bookings
{
    public class BookingDto : Dto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
        public EnumBookingStatus Status { get; set; } = EnumBookingStatus.Pending;
    }
}
