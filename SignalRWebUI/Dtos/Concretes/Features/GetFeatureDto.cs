using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Features
{
    public class GetFeatureDto : FeatureDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
