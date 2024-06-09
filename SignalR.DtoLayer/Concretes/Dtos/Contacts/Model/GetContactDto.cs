using SignalR.Core.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.SocialMedias;

namespace SignalR.DtoLayer.Concretes.Dtos.Contacts.Model
{
    public class GetContactDto : ContactDto, IDto<int>
    {
        public int Id { get; set; }
        public List<SocialMediaDto> SocialMedias { get; set; }
    }
}
