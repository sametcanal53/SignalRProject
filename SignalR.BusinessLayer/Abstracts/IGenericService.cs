namespace SignalR.BusinessLayer.Abstracts
{
    public interface IGenericService<T> where T : class
    {
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        T GetByID(int id);
        List<T> GetListAll();
    }
}
