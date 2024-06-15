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
        public virtual List<T> GetList(bool? includedPassive = false) => _context.Set<T>().AsEnumerable().Where(c => includedPassive.HasValue ? true : c.GetType().GetProperty("State").GetValue(c).Equals(true)).ToList();
        public virtual T GetById(int id) => _context.Set<T>().Find(id);
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

        public virtual T Delete(T entity) => ChangeState((int)entity.GetType().GetProperty("Id").GetValue(entity), false);

        public virtual int GetCount(bool? isActive)
        {
            var list = GetList();
            return EnumerableExtensions.IsActiveConditions(list, isActive).Count();
        }

        public virtual T ChangeState(int id, bool? state)
        {
            var entity = GetById(id);
            if (entity == null) return default;

            var property = entity.GetType().GetProperty("State");
            var currentState = (bool)property.GetValue(entity);

            property.SetValue(entity, state.HasValue ? state.Value : !currentState);

            return Update(entity);
        }
    }
}
