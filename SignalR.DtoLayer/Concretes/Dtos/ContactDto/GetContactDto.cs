using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.ContactDto
{
    public class GetContactDto : BaseContactDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
