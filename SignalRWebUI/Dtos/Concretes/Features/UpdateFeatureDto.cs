using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Features
{
    public class UpdateFeatureDto : FeatureDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
