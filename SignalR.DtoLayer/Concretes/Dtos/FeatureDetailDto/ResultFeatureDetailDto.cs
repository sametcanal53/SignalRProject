using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.FeatureDetailDto
{
    public class ResultFeatureDetailDto : BaseFeatureDetailDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
