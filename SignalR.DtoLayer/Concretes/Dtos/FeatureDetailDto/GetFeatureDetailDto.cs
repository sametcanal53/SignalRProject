using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.FeatureDetailDto
{
    public class GetFeatureDetailDto : BaseFeatureDetailDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
