using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstracts
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> GetProductsWithCategories();
        int ProductCountByCategoryName(string categoryName);
        decimal ProductPriceAvg(int? categoryId);
        string ProductNameByMaxPrice(int? categoryId);
        string ProductNameByMinPrice(int? categoryId);
    }
}
