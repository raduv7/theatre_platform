namespace theatre_platform_server.kdomain.interfaces.entities
{
    public interface IAdministrator : IAbstractUser
    {
        ITheatre Theatre { get; set; }
    }
}