using SignalR.DtoLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDetailDto;

namespace SignalR.DtoLayer.Concretes.Dtos.FeatureDto
{
    public class ResultFeatureWithFeatureDetailDto : BaseFeatureDto, IDto<int>
    {
        public int Id { get; set; }
        public List<GetFeatureDetailDto> FeatureDetails { get; set; }
    }
}
