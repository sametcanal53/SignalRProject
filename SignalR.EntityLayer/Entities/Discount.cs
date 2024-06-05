using SignalR.EntityLayer.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class Discount : Entity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public string ImageUrl { get; set; }
    }
}
