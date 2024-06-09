using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.MenuTables.Update
{
    public class UpdateMenuTableDto : MenuTableDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
