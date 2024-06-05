using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : GenericController<Product, ResultProductDto, GetProductDto, CreateProductDto, UpdateProductDto>
    {
        public ProductController(IGenericService<Product> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
