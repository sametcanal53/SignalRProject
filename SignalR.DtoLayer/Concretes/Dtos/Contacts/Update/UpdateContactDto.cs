using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Contacts.Update
{
    public class UpdateContactDto : ContactDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
