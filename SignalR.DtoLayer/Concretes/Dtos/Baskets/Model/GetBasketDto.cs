using SignalR.Core.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.MenuTables;
using SignalR.DtoLayer.Concretes.Dtos.Products;

namespace SignalR.DtoLayer.Concretes.Dtos.Baskets.Model
{
    public class GetBasketDto : BasketDto, IDto<int>
    {
        public int Id { get; set; }
        public ProductDto Product { get; set; }
        public MenuTableDto MenuTable { get; set; }
    }
}
