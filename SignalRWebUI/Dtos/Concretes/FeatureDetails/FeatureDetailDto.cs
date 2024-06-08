using SignalRWebUI.Dtos.Concretes.Base;

namespace SignalRWebUI.Dtos.Concretes.FeatureDetails
{
    public class FeatureDetailDto : Dto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int FeatureId { get; set; }
    }
}
