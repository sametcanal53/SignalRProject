using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.FeatureDetails.Model
{
    public class GetFeatureDetailDto : FeatureDetailDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
