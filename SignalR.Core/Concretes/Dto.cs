using SignalR.Core.Abstracts;

namespace SignalR.Core.Concretes
{
    public class Dto : IDto
    {
        public bool State { get; set; } = true;
    }

    public class Dto<TId> : Dto, IDto<TId>
    {
        public TId Id { get; set; }
    }
}
