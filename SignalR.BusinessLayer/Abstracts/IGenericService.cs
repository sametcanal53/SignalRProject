namespace SignalR.BusinessLayer.Abstracts
{
    public interface IGenericService<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetByID(int id);
        List<T> GetListAll();
    }
}
