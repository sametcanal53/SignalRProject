namespace SignalR.EntityLayer.Abstracts
{
    public interface IEntity
    {
        bool State { get; set; }
    }

    public interface IEntity<TId> : IEntity
    {
        TId Id { get; set; }
    }
}
