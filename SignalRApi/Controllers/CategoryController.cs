using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : GenericController<Category, ICategoryService, ResultCategoryDto, GetCategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {
        public CategoryController(ICategoryService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
