using SignalR.EntityLayer.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class Feature : Entity<int>
    {
        public string Name { get; set; }
        public List<FeatureDetail> FeatureDetails { get; set; }
    }
}
