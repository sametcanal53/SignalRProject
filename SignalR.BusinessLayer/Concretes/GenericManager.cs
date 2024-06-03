using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;

namespace SignalR.BusinessLayer.Concretes
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IGenericDal<T> _dal;

        public GenericManager(IGenericDal<T> dal)
        {
            _dal = dal;
        }

        public virtual List<T> GetListAll() => _dal.GetListAll();
        public virtual T GetByID(int id) => _dal.GetByID(id);
        public virtual void Add(T entity) => _dal.Add(entity);
        public virtual void Update(T entity) => _dal.Update(entity);
        public virtual void Delete(T entity) => _dal.Delete(entity);
    }
}
