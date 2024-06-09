using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.Products.Create;
using SignalR.DtoLayer.Concretes.Dtos.Products.Model;
using SignalR.DtoLayer.Concretes.Dtos.Products.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductWithCategoryDto>().ReverseMap();
        }
    }
}
