using SignalR.Core.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.OrderDetails;

namespace SignalR.DtoLayer.Concretes.Dtos.Orders.Model
{
    public class GetOrderDto : OrderDto, IDto<int>
    {
        public int Id { get; set; }
        public List<OrderDetailDto> OrderDetails { get; set; }
    }
}
