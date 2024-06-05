using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.BookingDto
{
    public class GetBookingDto : BaseBookingDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
