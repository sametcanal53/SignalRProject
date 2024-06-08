using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Concretes;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfFeatureDetailDal : GenericRepository<FeatureDetail>, IFeatureDetailDal
    {
        public EfFeatureDetailDal(SignalRContext context) : base(context)
        {
        }
    }
}
