using SignalR.Core.Abstracts;

namespace SignalR.Core.Concretes
{
    public class Entity : IEntity, IHasState
    {
        public int Id { get; set; }
        public bool State { get; set; } = true;
    }

    public class Entity<TId> : Entity, IEntity<TId>
    {
        public new required TId Id { get; set; }
    }
}
