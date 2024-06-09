using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstracts
{
    public interface IBasketDal : IGenericDal<Basket>
    {
        List<Basket> GetBasketByMenuTableNumber(int menuTableId);
    }
}
