using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Features.Update
{
    public class UpdateFeatureDto : FeatureDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
