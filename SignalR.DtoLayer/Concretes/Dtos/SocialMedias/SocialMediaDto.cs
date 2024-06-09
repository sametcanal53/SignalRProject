using SignalR.Core.Concretes;

namespace SignalR.DtoLayer.Concretes.Dtos.SocialMedias
{
    public class SocialMediaDto : Dto
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public int ContactId { get; set; }
    }
}
