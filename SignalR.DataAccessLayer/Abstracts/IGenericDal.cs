namespace SignalR.DataAccessLayer.Abstracts
{
    public interface IGenericDal<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetByID(int id);
        List<T> GetListAll();
    }
}
