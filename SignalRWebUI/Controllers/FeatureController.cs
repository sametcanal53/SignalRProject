using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SignalRWebUI.Dtos.Features.Create;
using SignalRWebUI.Dtos.Features.Model;
using SignalRWebUI.Dtos.Features.Update;

namespace SignalRWebUI.Controllers
{
    public class FeatureController : GenericController<GetFeatureDto, CreateFeatureDto, UpdateFeatureDto>
    {
        public FeatureController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

    }
}
