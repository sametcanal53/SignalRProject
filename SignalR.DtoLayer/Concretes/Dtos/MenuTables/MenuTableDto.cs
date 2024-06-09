using SignalR.Core.Concretes;
using SignalR.Enums;

namespace SignalR.DtoLayer.Concretes.Dtos.MenuTables
{
    public class MenuTableDto : Dto
    {
        public string Name { get; set; }
        public EnumMenuTableStatus Status { get; set; }
    }
}
