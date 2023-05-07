namespace theatre_platform_server.kdomain._interfaces.entities
{
    public interface IHall : IAbstractTableEntity
    {
        string Name { get; set; }
        ITheatre Theatre { get; set; }
    }
}