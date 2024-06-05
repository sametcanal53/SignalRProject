using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : GenericController<Category, ResultCategoryDto, GetCategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {
        public CategoryController(IGenericService<Category> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
