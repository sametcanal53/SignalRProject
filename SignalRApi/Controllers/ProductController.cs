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

        [HttpGet("ProductCountByCategoryName")]
        public IActionResult ProductCountByCategoryName(string categoryName = default) => Ok(_productService.ProductCountByCategoryName(categoryName));

        [HttpGet("ProductPriceAvg")]
        public IActionResult ProductPriceAvg(int? categoryId) => Ok(_productService.ProductPriceAvg(categoryId));

        [HttpGet("ProductNameByMaxPrice")]
        public IActionResult ProductNameByMaxPrice(int? categoryId) => Ok(_productService.ProductNameByMaxPrice(categoryId));

        [HttpGet("ProductNameByMinPrice")]
        public IActionResult ProductNameByMinPrice(int? categoryId) => Ok(_productService.ProductNameByMinPrice(categoryId));
    }
}
