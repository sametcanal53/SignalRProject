using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstracts
{
    public interface IProductService : IGenericService<Product>
    {
        int ProductCount(int? categoryId = default);
        decimal ProductPriceAvg(int? categoryId = default);
        string ProductNameByMaxPrice(int? categoryId = default);
        string ProductNameByMinPrice(int? categoryId = default);
    }
}
