using SignalR.EntityLayer.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class Testimonial : Entity<int>
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
