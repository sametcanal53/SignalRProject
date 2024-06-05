using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : GenericController<Product, IProductService, ResultProductDto, GetProductDto, CreateProductDto, UpdateProductDto>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService service, IMapper mapper) : base(service, mapper)
        {
            _productService = service;
            _mapper = mapper;
        }

        [HttpGet("GetProductListWithCategory")]
        public IActionResult GetProductListWithCategory()
        {
            var result = _mapper.Map<List<ResultProductWithCategory>>(_productService.GetProductsWithCategories());
            return Ok(result);
        }
    }
}
