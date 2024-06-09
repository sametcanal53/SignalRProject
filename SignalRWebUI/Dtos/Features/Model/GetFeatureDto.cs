using SignalR.Core.Abstracts;
using SignalRWebUI.Dtos.FeatureDetails;

namespace SignalRWebUI.Dtos.Features.Model
{
    public class GetFeatureDto : FeatureDto, IDto<int>
    {
        public int Id { get; set; }
        public List<FeatureDetailDto> FeatureDetails { get; set; }

    }
}
