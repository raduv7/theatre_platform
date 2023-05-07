namespace theatre_platform_server.kdomain._interfaces.entities
{
    public interface IAdministrator : IAbstractUser
    {
        ITheatre Theatre { get; set; }
    }
}