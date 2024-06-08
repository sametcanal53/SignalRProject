using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class FeatureDetailManager : GenericManager<FeatureDetail>, IFeatureDetailDal
    {
        public FeatureDetailManager(IFeatureDetailDal featureDetailDal) : base(featureDetailDal)
        {
        }
    }
}
