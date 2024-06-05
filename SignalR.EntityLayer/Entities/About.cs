using SignalR.EntityLayer.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class About : Entity<int>
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
