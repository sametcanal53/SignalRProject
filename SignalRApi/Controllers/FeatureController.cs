using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Features.Create;
using SignalR.DtoLayer.Concretes.Dtos.Features.Model;
using SignalR.DtoLayer.Concretes.Dtos.Features.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class FeatureController : GenericController<Feature, GetFeatureDto, CreateFeatureDto, UpdateFeatureDto>
    {
        public FeatureController(IFeatureService featureService, IMapper mapper) : base(featureService, mapper)
        {
        }

    }
}
