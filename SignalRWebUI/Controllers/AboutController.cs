using SignalRWebUI.Dtos.Abouts.Create;
using SignalRWebUI.Dtos.Abouts.Model;
using SignalRWebUI.Dtos.Abouts.Update;

namespace SignalRWebUI.Controllers
{
    public class AboutController : GenericController<GetAboutDto, CreateAboutDto, UpdateAboutDto>
    {
        public AboutController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
