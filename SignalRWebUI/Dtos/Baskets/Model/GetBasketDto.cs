using SignalR.Core.Abstracts;
using SignalRWebUI.Dtos.MenuTables;
using SignalRWebUI.Dtos.Products;

namespace SignalRWebUI.Dtos.Baskets.Model
{
    public class GetBasketDto : BasketDto, IDto<int>
    {
        public int Id { get; set; }
        public ProductDto Product { get; set; }
        public MenuTableDto MenuTable { get; set; }
    }
}
