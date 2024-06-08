using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class DiscountManager : GenericManager<Discount>, IDiscountService
    {
        public DiscountManager(IDiscountDal dal) : base(dal)
        {
        }
    }
}
