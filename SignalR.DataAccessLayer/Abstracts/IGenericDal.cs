namespace SignalR.DataAccessLayer.Abstracts
{
    public interface IGenericDal<T> where T : class
    {
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        T GetByID(int id);
        List<T> GetListAll();
        int GetCount(bool? isActive);
    }
}
