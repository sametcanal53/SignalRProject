using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.MenuTables.Update
{
    public class UpdateMenuTableDto : MenuTableDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
