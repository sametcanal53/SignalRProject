using SignalRWebUI.Dtos.Concretes.Features;

namespace SignalRWebUI.Controllers
{
    public class FeatureController : BaseController<ResultFeatureDto, CreateFeatureDto, UpdateFeatureDto>
    {
        public FeatureController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
