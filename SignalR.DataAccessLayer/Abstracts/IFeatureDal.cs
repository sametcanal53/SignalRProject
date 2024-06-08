using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstracts
{
    public interface IFeatureDal : IGenericDal<Feature>
    {
        List<Feature> GetFeaturesWithFeatureDetails();
    }
}
