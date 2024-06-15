using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Concretes;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfUserDal : GenericRepository<User>, IUserDal
    {
        public EfUserDal(SignalRContext context) : base(context)
        {
        }
    }
}
