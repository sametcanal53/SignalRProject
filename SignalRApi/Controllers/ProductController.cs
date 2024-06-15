using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Products.ControllerRequest;
using SignalR.DtoLayer.Concretes.Dtos.Products.Create;
using SignalR.DtoLayer.Concretes.Dtos.Products.Model;
using SignalR.DtoLayer.Concretes.Dtos.Products.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class ProductController : GenericController<Product, GetProductDto, CreateProductDto, UpdateProductDto>
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService, IMapper mapper) : base(productService, mapper)
        {
            _productService = productService;
        }

        [HttpGet("ProductCountByCategoryName")]
        public IActionResult ProductCountByCategoryName(ProductCountByCategoryNameRequest request) => Ok(_productService.ProductCountByCategoryName(request.CategoryName));

        [HttpGet("ProductPriceAvg")]
        public IActionResult ProductPriceAvg(ProductPriceAvgRequest request) => Ok(_productService.ProductPriceAvg(request.CategoryId));

        [HttpGet("ProductNameByMaxPrice")]
        public IActionResult ProductNameByMaxPrice(ProductNameByMaxPriceRequest request) => Ok(_productService.ProductNameByMaxPrice(request.CategoryId));

        [HttpGet("ProductNameByMinPrice")]
        public IActionResult ProductNameByMinPrice(ProductNameByMinPriceRequest request) => Ok(_productService.ProductNameByMinPrice(request.CategoryId));
    }
}
