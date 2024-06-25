using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class ProductManager : GenericManager<Product>, IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal) : base(productDal)
        {
            _productDal = productDal;
        }

        public int ProductCount(int? categoryId) => _productDal.ProductCount(categoryId);
        public decimal ProductPriceAvg(int? categoryId) => _productDal.ProductPriceAvg(categoryId);
        public string ProductNameByMaxPrice(int? categoryId) => _productDal.ProductNameByMaxPrice(categoryId);
        public string ProductNameByMinPrice(int? categoryId) => _productDal.ProductNameByMinPrice(categoryId);

    }
}
