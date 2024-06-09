using SignalR.Core.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class Basket : Entity<int>
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int MenuTableId { get; set; }
        public MenuTable MenuTable { get; set; }

    }
}
