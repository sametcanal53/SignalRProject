using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDetailDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class FeatureDetailsController : GenericController<FeatureDetail, ResultFeatureDetailDto, GetFeatureDetailDto, CreateFeatureDetailDto, UpdateFeatureDetailDto>
    {
        public FeatureDetailsController(IFeatureDetailService featureDetailService, IMapper mapper) : base(featureDetailService, mapper)
        {
        }
    }
}
