using Microsoft.EntityFrameworkCore;
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
            return IsActiveConditions(list, isActive).Count();
        }

        // Protected Methods
        protected virtual IEnumerable<T> IsActiveConditions(IEnumerable<T> queryable, bool? isActive = default) => queryable.Where(q => !isActive.HasValue || q.GetType().GetProperty("State") == null ? true : q.GetType().GetProperty("State").GetValue(q).Equals(isActive.Value));
    }
}
