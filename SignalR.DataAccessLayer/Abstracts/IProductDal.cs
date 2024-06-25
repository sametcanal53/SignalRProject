using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstracts
{
    public interface IProductDal : IGenericDal<Product>
    {
        int ProductCount(int? categoryId);
        decimal ProductPriceAvg(int? categoryId);
        string ProductNameByMaxPrice(int? categoryId);
        string ProductNameByMinPrice(int? categoryId);
    }
}
