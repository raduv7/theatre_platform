namespace theatre_platform_server.kdomain.interfaces.entities
{
    public interface ITheatre : IAbstractTableEntity
    {
        string Name { get; set; }
        string Address { get; set; }
        int EstablishmentYear { get; set; }
    }
}