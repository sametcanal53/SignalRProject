using SignalRWebUI.Dtos.Abstracts;
using SignalRWebUI.Dtos.Concretes.FeatureDetails;

namespace SignalRWebUI.Dtos.Concretes.Features
{
    public class ResultFeatureWithFeatureDetailDto : FeatureDto, IDto<int>
    {
        public int Id { get; set; }
        public List<GetFeatureDetailDto> FeatureDetails { get; set; }
    }
}
