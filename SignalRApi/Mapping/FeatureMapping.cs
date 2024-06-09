using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.Features.Create;
using SignalR.DtoLayer.Concretes.Dtos.Features.Model;
using SignalR.DtoLayer.Concretes.Dtos.Features.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class FeatureMapping : Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureWithFeatureDetailsDto>().ReverseMap();
        }
    }
}
