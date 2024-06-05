using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : GenericController<Feature, ResultFeatureDto, GetFeatureDto, CreateFeatureDto, UpdateFeatureDto>
    {
        public FeatureController(IGenericService<Feature> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
