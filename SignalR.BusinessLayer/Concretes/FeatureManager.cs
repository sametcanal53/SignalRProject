using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class FeatureManager : GenericManager<Feature>, IFeatureService
    {
        private readonly IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal) : base(featureDal)
        {
            _featureDal = featureDal;
        }

        public List<Feature> GetFeaturesWithFeatureDetails() => _featureDal.GetFeaturesWithFeatureDetails();
    }
}
