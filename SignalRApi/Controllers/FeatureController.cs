using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class FeatureController : GenericController<Feature, ResultFeatureDto, GetFeatureDto, CreateFeatureDto, UpdateFeatureDto>
    {
        public FeatureController(IFeatureService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
