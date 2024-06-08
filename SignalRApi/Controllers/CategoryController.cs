using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class CategoryController : GenericController<Category, ResultCategoryDto, GetCategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {
        public CategoryController(ICategoryService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
