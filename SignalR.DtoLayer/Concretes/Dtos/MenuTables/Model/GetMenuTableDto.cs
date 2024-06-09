using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.MenuTables.Model
{
    public class GetMenuTableDto : MenuTableDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
