using SignalR.Core.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class SocialMedia : Entity<int>
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
