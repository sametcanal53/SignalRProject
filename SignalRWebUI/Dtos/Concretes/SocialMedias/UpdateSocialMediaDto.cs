using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.SocialMedias
{
    public class UpdateSocialMediaDto : BaseSocialMediaDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
