using SignalR.EntityLayer.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class Category : Entity<int>
    {
        public string Name { get; set; }
        public bool Status { get; set; }

        public List<Product> Products { get; set; }
    }
}
