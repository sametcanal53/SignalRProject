using SignalR.Core.Enums;

namespace SignalR.DtoLayer.Concretes.Dtos.Bookings.ControllerRequest
{
    public class ChangeBookingStatusRequest
    {
        public int Id { get; set; }
        public EnumBookingStatus Status { get; set; }
    }
}
