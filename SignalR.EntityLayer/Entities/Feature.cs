using SignalR.Core.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class Feature : Entity<int>
    {
        public string Name { get; set; }
        public virtual List<FeatureDetail> FeatureDetails { get; set; }
    }
}
