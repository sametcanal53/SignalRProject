using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class FeatureDetailManager : GenericManager<FeatureDetail>, IFeatureDetailService
    {
        public FeatureDetailManager(IFeatureDetailDal featureDetailDal) : base(featureDetailDal)
        {
        }
    }
}
