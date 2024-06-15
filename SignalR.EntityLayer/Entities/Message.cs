using SignalR.Core.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class Message : Entity<int>
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool IsRead { get; set; }
    }
}
