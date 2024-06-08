using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.FeatureDetails
{
    public class GetFeatureDetailDto : FeatureDetailDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
