using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.FeatureDetails.Model
{
    public class GetFeatureDetailDto : FeatureDetailDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
