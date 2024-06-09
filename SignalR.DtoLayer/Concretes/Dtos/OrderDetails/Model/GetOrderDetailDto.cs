using SignalR.Core.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Orders;
using SignalR.DtoLayer.Concretes.Dtos.Products;

namespace SignalR.DtoLayer.Concretes.Dtos.OrderDetails.Model
{
    public class GetOrderDetailDto : OrderDetailDto, IDto<int>
    {
        public int Id { get; set; }
        public ProductDto Product { get; set; }
        public OrderDto Order { get; set; }
    }
}
