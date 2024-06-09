using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.FeatureDetails.Update
{
    public class UpdateFeatureDetailDto : FeatureDetailDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
