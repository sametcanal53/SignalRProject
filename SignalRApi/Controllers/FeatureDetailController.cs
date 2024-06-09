using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDetails.Create;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDetails.Model;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDetails.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class FeatureDetailController : GenericController<FeatureDetail, GetFeatureDetailDto, CreateFeatureDetailDto, UpdateFeatureDetailDto>
    {
        public FeatureDetailController(IFeatureDetailService featureDetailService, IMapper mapper) : base(featureDetailService, mapper)
        {
        }
    }
}
