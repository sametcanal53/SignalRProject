using SignalR.Core.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Baskets;

namespace SignalR.DtoLayer.Concretes.Dtos.MenuTables.Model
{
    public class GetMenuTableDto : MenuTableDto, IDto<int>
    {
        public int Id { get; set; }
        public List<BasketDto> Baskets { get; set; }
    }
}
