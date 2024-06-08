using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDetailDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class FeatureDetailMapping : Profile
    {
        public FeatureDetailMapping()
        {
            CreateMap<FeatureDetail, ResultFeatureDetailDto>().ReverseMap();
            CreateMap<FeatureDetail, GetFeatureDetailDto>().ReverseMap();
            CreateMap<FeatureDetail, CreateFeatureDetailDto>().ReverseMap();
            CreateMap<FeatureDetail, UpdateFeatureDetailDto>().ReverseMap();
        }
    }
}
