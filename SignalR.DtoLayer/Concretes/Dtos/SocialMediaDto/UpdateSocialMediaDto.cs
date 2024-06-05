using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.SocialMediaDto
{
    public class UpdateSocialMediaDto : BaseSocialMediaDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
