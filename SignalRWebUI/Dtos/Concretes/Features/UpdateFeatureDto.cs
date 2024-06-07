using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Features
{
    public class UpdateFeatureDto : BaseFeatureDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
