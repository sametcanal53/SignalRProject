using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.SocialMedias
{
    public class GetSocialMediaDto : BaseSocialMediaDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
