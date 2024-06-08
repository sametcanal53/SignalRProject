using SignalR.EntityLayer.Abstracts;

namespace SignalR.EntityLayer.Concretes
{
    public class Entity : IEntity
    {
        public bool State { get; set; } = true;
    }

    public class Entity<TId> : Entity, IEntity<TId>
    {
        public TId Id { get; set; }
    }
}
