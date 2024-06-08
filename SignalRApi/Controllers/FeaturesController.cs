using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class FeaturesController : GenericController<Feature, ResultFeatureDto, GetFeatureDto, CreateFeatureDto, UpdateFeatureDto>
    {
        public FeaturesController(IFeatureService featureService, IMapper mapper) : base(featureService, mapper)
        {
        }
    }
}
