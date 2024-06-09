using SignalR.Core.Abstracts;
using SignalRWebUI.Dtos.FeatureDetails.Model;

namespace SignalRWebUI.Dtos.Features.Model
{
    public class GetFeatureWithFeatureDetailsDto : FeatureDto, IDto<int>
    {
        public int Id { get; set; }
        public List<GetFeatureDetailDto> FeatureDetails { get; set; }
    }
}
