using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.MoneyCaseDto
{
    public class ResultMoneyCaseDto : BaseMoneyCaseDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
