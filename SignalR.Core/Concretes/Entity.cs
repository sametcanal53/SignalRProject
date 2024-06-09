using SignalR.Core.Abstracts;

namespace SignalR.Core.Concretes
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
