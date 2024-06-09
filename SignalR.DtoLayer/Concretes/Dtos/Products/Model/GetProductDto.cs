using SignalR.Core.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Baskets;
using SignalR.DtoLayer.Concretes.Dtos.Categories;
using SignalR.DtoLayer.Concretes.Dtos.OrderDetails;

namespace SignalR.DtoLayer.Concretes.Dtos.Products.Model
{
    public class GetProductDto : ProductDto, IDto<int>
    {
        public int Id { get; set; }
        public CategoryDto Category { get; set; }
        public List<OrderDetailDto> OrderDetails { get; set; }
        public List<BasketDto> Baskets { get; set; }
    }
}
