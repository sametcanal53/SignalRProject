using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstracts
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();
    }
}
