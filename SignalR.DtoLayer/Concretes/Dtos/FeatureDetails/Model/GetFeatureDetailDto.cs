using SignalR.Core.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Features;

namespace SignalR.DtoLayer.Concretes.Dtos.FeatureDetails.Model
{
    public class GetFeatureDetailDto : FeatureDetailDto, IDto<int>
    {
        public int Id { get; set; }
        public FeatureDto Feature { get; set; }
    }
}
