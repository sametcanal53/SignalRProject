using SignalR.Core.Extensions;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Concretes;

namespace SignalR.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly SignalRContext _context;

        public GenericRepository(SignalRContext context)
        {
            _context = context;
        }
        public virtual List<T> GetListAll() => _context.Set<T>().ToList();
        public virtual T GetByID(int id) => _context.Set<T>().Find(id);
        public virtual T Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
            return entity;
        }
        public virtual T Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual T Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual int GetCount(bool? isActive)
        {
            var list = GetListAll();
            return EnumerableExtensions.IsActiveConditions(list, isActive).Count();
        }

    }
}
