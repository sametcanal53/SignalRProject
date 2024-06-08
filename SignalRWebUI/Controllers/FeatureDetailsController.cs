using SignalRWebUI.Dtos.Concretes.FeatureDetails;

namespace SignalRWebUI.Controllers
{
    public class FeatureDetailsController : GenericController<ResultFeatureDetailDto, CreateFeatureDetailDto, UpdateFeatureDetailDto>
    {
        public FeatureDetailsController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
