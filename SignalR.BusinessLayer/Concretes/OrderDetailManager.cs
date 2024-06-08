using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class OrderDetailManager : GenericManager<OrderDetail>, IOrderDetailService
    {
        public OrderDetailManager(IOrderDetailDal dal) : base(dal)
        {
        }
    }
}
