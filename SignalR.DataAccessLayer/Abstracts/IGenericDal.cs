namespace SignalR.DataAccessLayer.Abstracts
{
    public interface IGenericDal<T>
    {
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        T GetById(int id);
        List<T> GetList(bool? includedPassive);
        int GetCount(bool? isActive);
        T ChangeState(int id, bool? state);
    }
}
