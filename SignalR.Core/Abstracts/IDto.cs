namespace SignalR.Core.Abstracts
{
    public interface IDto
    {
    }

    public interface IDto<TId> : IDto
    {
        TId Id { get; set; }
    }
}
