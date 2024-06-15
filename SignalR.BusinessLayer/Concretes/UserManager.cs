using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class UserManager : GenericManager<User>, IUserService
    {
        public UserManager(IUserDal userDal) : base(userDal)
        {
        }
    }
}
