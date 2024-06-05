namespace SignalR.DtoLayer.Abstracts
{
    public interface IDto
    {
    }

    public interface IDto<TId> : IDto
    {
        TId Id { get; set; }
    }
}
