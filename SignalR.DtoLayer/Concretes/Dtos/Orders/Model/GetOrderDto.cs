using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Orders.Model
{
    public class GetOrderDto : OrderDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
