using theatre_platform_server.kdomain.interfaces.entities;

namespace theatre_platform_server.kdomain.entities
{
    public class Administrator : AbstractUser, IAdministrator
    {
        private ITheatre _theatre = null!;

        public Administrator() { }

        public Administrator(ITheatre theatre, string firstName, string lastName, string userName, string emailAddress,
            string salt, string password, int id)
            : base(firstName, lastName, userName, emailAddress, salt, password, id)
        {
            this._theatre = theatre;
        }
    
        public ITheatre Theatre
        {
            get => _theatre;
            set => _theatre = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}