using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.FeatureDetails.Update
{
    public class UpdateFeatureDetailDto : FeatureDetailDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
