using SignalR.Core.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class Basket : Entity<int>
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int MenuTableId { get; set; }
        public virtual MenuTable MenuTable { get; set; }
        public int Amount { get; set; }
    }
}
