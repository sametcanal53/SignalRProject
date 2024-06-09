using SignalR.Core.Abstracts;
using SignalRWebUI.Dtos.Orders;
using SignalRWebUI.Dtos.Products;

namespace SignalRWebUI.Dtos.OrderDetails.Model
{
    public class GetOrderDetailDto : OrderDetailDto, IDto<int>
    {
        public int Id { get; set; }
        public ProductDto Product { get; set; }
        public OrderDto Order { get; set; }
    }
}
