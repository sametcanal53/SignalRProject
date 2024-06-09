using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Features.Update
{
    public class UpdateFeatureDto : FeatureDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
