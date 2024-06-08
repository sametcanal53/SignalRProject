using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstracts
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();
        int ProductCountByCategoryName(string categoryName);
        decimal ProductPriceAvg(int? categoryId);
        string ProductNameByMaxPrice(int? categoryId);
        string ProductNameByMinPrice(int? categoryId);
    }
}
