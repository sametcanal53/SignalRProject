using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Features.Model
{
    public class GetFeatureDto : FeatureDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
