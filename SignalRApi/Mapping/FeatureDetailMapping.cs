using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDetails;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDetails.Create;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDetails.Model;
using SignalR.DtoLayer.Concretes.Dtos.FeatureDetails.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class FeatureDetailMapping : Profile
    {
        public FeatureDetailMapping()
        {
            CreateMap<FeatureDetail, FeatureDetailDto>().ReverseMap();
            CreateMap<FeatureDetail, GetFeatureDetailDto>().ReverseMap();
            CreateMap<FeatureDetail, CreateFeatureDetailDto>().ReverseMap();
            CreateMap<FeatureDetail, UpdateFeatureDetailDto>().ReverseMap();
        }
    }
}
