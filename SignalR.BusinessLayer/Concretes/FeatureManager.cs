using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class FeatureManager : GenericManager<Feature>, IFeatureService
    {
        private readonly IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal dal) : base(dal)
        {
            _featureDal = dal;
        }

        public List<Feature> GetFeaturesWithFeatureDetails() => _featureDal.GetFeaturesWithFeatureDetails();
    }
}
