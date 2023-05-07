namespace theatre_platform_server.kdomain._interfaces.entities
{
    public interface IAbstractUser : IAbstractTableEntity
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string UserName { get; set; }
        string EmailAddress { get; set; }
        string Password { get; set; }
        string Salt { get; set; }
    }
}