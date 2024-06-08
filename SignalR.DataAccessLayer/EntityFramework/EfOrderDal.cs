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

        public int OrderCount(bool? isActive) => _context.Orders.Where(o => !isActive.HasValue || o.State == isActive).Count();
    }
}
