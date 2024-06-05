using SignalR.EntityLayer.Abstracts;

namespace SignalR.EntityLayer.Concretes
{
    public class Entity : IEntity
    {
    }

    public class Entity<TId> : IEntity<TId>
    {
        public TId Id { get; set; }
    }
}
