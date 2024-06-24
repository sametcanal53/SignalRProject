using SignalR.Core.Extensions;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Concretes;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        private readonly SignalRContext _context;
        public EfOrderDal(SignalRContext context) : base(context)
        {
            _context = context;
        }

        public decimal LastOrderPrice(bool? isActive) => _context.Orders.WhereIf(o => true, isActive.Value == true).OrderByDescending(o => o.Id).Select(o => o.TotalPrice).FirstOrDefault();
    }
}
