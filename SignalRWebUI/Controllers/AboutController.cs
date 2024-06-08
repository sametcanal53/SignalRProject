using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.Dtos.Concretes.Abouts;

namespace SignalRWebUI.Controllers
{
    public class AboutController : GenericController<ResultAboutDto, CreateAboutDto, UpdateAboutDto>
    {
        public AboutController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
