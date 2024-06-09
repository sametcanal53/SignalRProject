using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.SocialMedias.Update
{
    public class UpdateSocialMediaDto : SocialMediaDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
