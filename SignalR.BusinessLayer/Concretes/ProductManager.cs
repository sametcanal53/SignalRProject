using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class ProductManager : GenericManager<Product>, IProductService
    {
        private readonly IProductDal _dal;

        public ProductManager(IProductDal dal) : base(dal)
        {
            _dal = dal;
        }

        public List<Product> GetProductsWithCategories() => _dal.GetProductsWithCategories();
        public int ProductCountByCategoryName(string categoryName) => _dal.ProductCountByCategoryName(categoryName);
        public decimal ProductPriceAvg(int? categoryId) => _dal.ProductPriceAvg(categoryId);
        public string ProductNameByMaxPrice(int? categoryId) => _dal.ProductNameByMaxPrice(categoryId);
        public string ProductNameByMinPrice(int? categoryId) => _dal.ProductNameByMinPrice(categoryId);

    }
}
