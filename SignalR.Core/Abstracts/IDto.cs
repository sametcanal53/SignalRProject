namespace SignalR.Core.Abstracts
{
    public interface IDto
    {
        public bool State { get; set; }
    }

    public interface IDto<TId> : IDto
    {
        TId Id { get; set; }
    }
}
