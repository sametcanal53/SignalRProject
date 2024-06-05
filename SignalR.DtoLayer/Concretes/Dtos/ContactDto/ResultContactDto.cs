using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.ContactDto
{
    public class ResultContactDto : BaseContactDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
