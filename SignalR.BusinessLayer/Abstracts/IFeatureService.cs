using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstracts
{
    public interface IFeatureService : IGenericService<Feature>
    {
        List<Feature> GetFeaturesWithFeatureDetails();
    }
}
