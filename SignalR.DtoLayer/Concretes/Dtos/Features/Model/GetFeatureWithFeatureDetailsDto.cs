using SignalR.Core.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDetails.Model;

namespace SignalR.DtoLayer.Concretes.Dtos.Features.Model
{
    public class GetFeatureWithFeatureDetailsDto : FeatureDto, IDto<int>
    {
        public int Id { get; set; }
        public List<GetFeatureDetailDto> FeatureDetails { get; set; }
    }
}
