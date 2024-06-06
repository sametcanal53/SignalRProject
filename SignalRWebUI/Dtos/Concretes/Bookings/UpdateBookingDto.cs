using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Bookings
{
    public class UpdateBookingDto : BaseBookingDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
