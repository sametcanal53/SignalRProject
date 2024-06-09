using SignalR.Core.Abstracts;
using SignalRWebUI.Dtos.Baskets;
using SignalRWebUI.Dtos.Categories;
using SignalRWebUI.Dtos.OrderDetails;

namespace SignalRWebUI.Dtos.Products.Model
{
    public class GetProductDto : ProductDto, IDto<int>
    {
        public int Id { get; set; }
        public CategoryDto Category { get; set; }
        public List<OrderDetailDto> OrderDetails { get; set; }
        public List<BasketDto> Baskets { get; set; }

    }
}
