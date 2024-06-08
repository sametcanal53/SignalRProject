using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.OrderDto
{
    public class GetOrderDto : BaseOrderDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
