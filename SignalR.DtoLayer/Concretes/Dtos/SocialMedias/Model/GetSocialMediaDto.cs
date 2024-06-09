using SignalR.Core.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Contacts;

namespace SignalR.DtoLayer.Concretes.Dtos.SocialMedias.Model
{
    public class GetSocialMediaDto : SocialMediaDto, IDto<int>
    {
        public int Id { get; set; }
        public ContactDto Contact { get; set; }

    }
}
