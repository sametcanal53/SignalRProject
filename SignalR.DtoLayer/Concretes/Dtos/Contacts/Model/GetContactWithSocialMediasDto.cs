using SignalR.Core.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.SocialMedias.Model;

namespace SignalR.DtoLayer.Concretes.Dtos.Contacts.Model
{
    public class GetContactWithSocialMediasDto : ContactDto, IDto<int>
    {
        public int Id { get; set; }
        public List<GetSocialMediaDto> SocialMedias { get; set; }
    }
}
