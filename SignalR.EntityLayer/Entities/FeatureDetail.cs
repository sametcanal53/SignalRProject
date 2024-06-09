using SignalR.Core.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class FeatureDetail : Entity<int>
    {
        public int FeatureId { get; set; }
        public virtual Feature Feature { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
