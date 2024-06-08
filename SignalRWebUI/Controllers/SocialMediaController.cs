using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.Dtos.Concretes.SocialMedias;

namespace SignalRWebUI.Controllers
{
    public class SocialMediaController : GenericController<ResultSocialMediaDto, CreateSocialMediaDto, UpdateSocialMediaDto>
    {
        public SocialMediaController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
