using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.MoneyCaseDto
{
    public class UpdateMoneyCaseDto : BaseMoneyCaseDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
