using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Features.Model
{
    public class GetFeatureDto : FeatureDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
