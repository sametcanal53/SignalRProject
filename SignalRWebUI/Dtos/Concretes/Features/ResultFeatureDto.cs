using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Features
{
    public class ResultFeatureDto : FeatureDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
