using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class BasketManager : GenericManager<Basket>, IBasketService
    {
        private readonly IBasketDal _basketDal;
        public BasketManager(IBasketDal basketDal) : base(basketDal)
        {
            _basketDal = basketDal;
        }

        public List<Basket> GetBasketByMenuTableNumber(int menuTableId) => _basketDal.GetBasketByMenuTableNumber(menuTableId);
    }
}
