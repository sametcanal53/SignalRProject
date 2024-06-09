using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDetails.Create;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDetails.Model;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDetails.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class FeatureDetailsController : GenericController<FeatureDetail, GetFeatureDetailDto, CreateFeatureDetailDto, UpdateFeatureDetailDto>
    {
        public FeatureDetailsController(IFeatureDetailService featureDetailService, IMapper mapper) : base(featureDetailService, mapper)
        {
        }
    }
}
