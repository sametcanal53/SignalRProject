using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Bookings
{
    public class GetBookingDto : BaseBookingDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
