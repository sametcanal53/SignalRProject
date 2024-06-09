using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstracts
{
    public interface IBasketService : IGenericService<Basket>
    {
        List<Basket> GetBasketByMenuTableNumber(int menuTableId);
    }
}
