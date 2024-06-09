using SignalR.Core.Concretes;

namespace SignalR.DtoLayer.Concretes.Dtos.FeatureDetails
{
    public class FeatureDetailDto : Dto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int FeatureId { get; set; }
    }
}
