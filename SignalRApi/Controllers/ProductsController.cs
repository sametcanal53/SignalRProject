using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Products.Create;
using SignalR.DtoLayer.Concretes.Dtos.Products.Model;
using SignalR.DtoLayer.Concretes.Dtos.Products.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class ProductsController : GenericController<Product, GetProductDto, CreateProductDto, UpdateProductDto>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper) : base(productService, mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet("GetProductListWithCategory")]
        public IActionResult GetProductListWithCategory()
        {
            var result = _mapper.Map<List<GetProductWithCategoryDto>>(_productService.GetProductsWithCategories());
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
