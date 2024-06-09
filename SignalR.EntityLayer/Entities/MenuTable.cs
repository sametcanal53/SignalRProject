using SignalR.Core.Concretes;
using SignalR.Enums;

namespace SignalR.EntityLayer.Entities
{
    public class MenuTable : Entity<int>
    {
        public string Name { get; set; }
        public EnumMenuTableStatus Status { get; set; }
        public virtual List<Basket> Baskets { get; set; }

    }
}
