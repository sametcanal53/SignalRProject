using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class OrderManager : GenericManager<Order>, IOrderService
    {
        private readonly IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal) : base(orderDal)
        {
            _orderDal = orderDal;
        }
        public decimal LastOrderPrice(bool? isActive) => _orderDal.LastOrderPrice(isActive);
    }
}
