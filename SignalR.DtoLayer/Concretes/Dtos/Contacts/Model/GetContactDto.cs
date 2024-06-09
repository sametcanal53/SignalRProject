using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Contacts.Model
{
    public class GetContactDto : ContactDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
