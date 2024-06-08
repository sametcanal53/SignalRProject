using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class OrderManager : GenericManager<Order>, IOrderService
    {
        private readonly IOrderDal _dal;
        public OrderManager(IOrderDal dal) : base(dal)
        {
            _dal = dal;
        }

        public int OrderCount(bool? isActive) => _dal.OrderCount(isActive);
        public decimal LastOrderPrice(bool? isActive) => _dal.LastOrderPrice(isActive);
    }
}
