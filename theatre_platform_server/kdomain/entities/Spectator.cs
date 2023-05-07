using theatre_platform_server.kdomain.interfaces.entities;

namespace theatre_platform_server.kdomain.entities
{
    public class Spectator : AbstractUser, ISpectator
    {
        public Spectator() { }

        public Spectator(string firstName, string lastName, string userName, string emailAddress, string salt, string password, int id) 
            : base(firstName, lastName, userName, emailAddress, salt, password, id) { }
    
    }
}