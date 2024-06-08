using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class FeaturesController : GenericController<Feature, ResultFeatureDto, GetFeatureDto>
    {
        private readonly IFeatureService _featureService;
        public FeaturesController(IFeatureService featureService, IMapper mapper) : base(featureService, mapper)
        {
            _featureService = featureService;
        }

        [HttpGet("GetFeaturesWithFeatureDetails")]
        public IActionResult GetFeaturesWithFeatureDetails() => Ok(_featureService.GetFeaturesWithFeatureDetails());
    }
}
