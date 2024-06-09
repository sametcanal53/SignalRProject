using SignalR.Core.Abstracts;
using SignalRWebUI.Dtos.Features;

namespace SignalRWebUI.Dtos.FeatureDetails.Model
{
    public class GetFeatureDetailDto : FeatureDetailDto, IDto<int>
    {
        public int Id { get; set; }
        public FeatureDto Feature { get; set; }
    }
}
