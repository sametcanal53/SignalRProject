using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Concretes;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        private readonly SignalRContext _context;
        public EfFeatureDal(SignalRContext context) : base(context)
        {
            _context = context;
        }

        public List<Feature> GetFeaturesWithFeatureDetails() => _context.Features.Include(f => f.FeatureDetails).ToList();
    }
}
