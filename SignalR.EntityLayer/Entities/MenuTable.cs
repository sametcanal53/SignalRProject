using SignalR.EntityLayer.Concretes;
using SignalR.Enums;

namespace SignalR.EntityLayer.Entities
{
    public class MenuTable : Entity<int>
    {
        public string Name { get; set; }
        public EnumMenuTableStatus Status { get; set; }
    }
}
