using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.Dtos.Concretes.SocialMedias;

namespace SignalRWebUI.Controllers
{
    public class SocialMediaController : BaseController<ResultSocialMediaDto, CreateSocialMediaDto, UpdateSocialMediaDto>
    {
        public SocialMediaController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
