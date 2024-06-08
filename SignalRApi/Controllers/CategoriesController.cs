using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class CategoriesController : GenericController<Category, ResultCategoryDto, GetCategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {
        public CategoriesController(ICategoryService categoryService, IMapper mapper) : base(categoryService, mapper)
        {
        }
    }
}
