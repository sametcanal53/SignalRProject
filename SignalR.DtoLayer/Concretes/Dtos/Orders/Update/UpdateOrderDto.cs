using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Orders.Update
{
    public class UpdateOrderDto : OrderDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
