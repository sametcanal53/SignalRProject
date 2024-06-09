using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Categories.Create;
using SignalR.DtoLayer.Concretes.Dtos.Categories.Model;
using SignalR.DtoLayer.Concretes.Dtos.Categories.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class CategoriesController : GenericController<Category, GetCategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {
        public CategoriesController(ICategoryService categoryService, IMapper mapper) : base(categoryService, mapper)
        {
        }
    }
}
