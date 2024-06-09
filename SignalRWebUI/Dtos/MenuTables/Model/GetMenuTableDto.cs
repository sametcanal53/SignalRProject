using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.MenuTables.Model
{
    public class GetMenuTableDto : MenuTableDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
