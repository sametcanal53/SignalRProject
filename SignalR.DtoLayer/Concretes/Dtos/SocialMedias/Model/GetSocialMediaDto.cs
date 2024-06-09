using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.SocialMedias.Model
{
    public class GetSocialMediaDto : SocialMediaDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
