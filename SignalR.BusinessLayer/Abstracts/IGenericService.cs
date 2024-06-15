namespace SignalR.BusinessLayer.Abstracts
{
    public interface IGenericService<T> where T : class
    {
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        T GetById(int id);
        List<T> GetList(bool? includedPassive);
        int GetCount(bool? isActive = default);
        T ChangeState(int id, bool? state);

    }
}
