using SignalR.Core.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDetails;

namespace SignalR.DtoLayer.Concretes.Dtos.Features.Model
{
    public class GetFeatureDto : FeatureDto, IDto<int>
    {
        public int Id { get; set; }
        public List<FeatureDetailDto> FeatureDetails { get; set; }

    }
}
