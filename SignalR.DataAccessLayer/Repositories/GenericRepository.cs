using SignalR.Core.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Concretes;

namespace SignalR.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T>
        where T : class, IEntity, IHasState
    {
        private readonly SignalRContext _context;

        public GenericRepository(SignalRContext context)
        {
            _context = context;
        }

        public virtual List<T> GetList(bool? includedPassive = false) => _context.Set<T>().AsEnumerable().Where(t => includedPassive.GetValueOrDefault().Equals(true) ? true : t.State.Equals(true)).ToList();
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
        public virtual int GetCount(bool? isActive) => GetList(!isActive).Count;
        public T ChangeState(int id, bool? state)
        {
            var entity = GetById(id);
            if (entity is not IHasState hasState) return default;

            entity.State = state.HasValue ? state.Value : !entity.State;
            return Update(entity);
        }
    }
}
