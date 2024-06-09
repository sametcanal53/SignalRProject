using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Bookings.Model
{
    public class GetBookingDto : BookingDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
