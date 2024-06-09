using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.Categories.Create;
using SignalR.DtoLayer.Concretes.Dtos.Categories.Model;
using SignalR.DtoLayer.Concretes.Dtos.Categories.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        }
    }
}
