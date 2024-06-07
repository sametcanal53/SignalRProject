using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Features
{
    public class ResultFeatureDto : BaseFeatureDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
