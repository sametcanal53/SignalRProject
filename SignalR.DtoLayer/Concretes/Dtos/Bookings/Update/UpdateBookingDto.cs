using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Bookings.Update
{
    public class UpdateBookingDto : BookingDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
