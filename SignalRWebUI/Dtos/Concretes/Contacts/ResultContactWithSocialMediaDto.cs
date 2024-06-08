using SignalRWebUI.Dtos.Abstracts;
using SignalRWebUI.Dtos.Concretes.SocialMedias;

namespace SignalRWebUI.Dtos.Concretes.Contacts
{
    public class ResultContactWithSocialMediaDto : ContactDto, IDto<int>
    {
        public int Id { get; set; }
        public List<GetSocialMediaDto> SocialMedias { get; set; }
    }
}
