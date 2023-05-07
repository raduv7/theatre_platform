using theatre_platform_server.kdomain._interfaces.entities;

namespace theatre_platform_server.kdomain.entities
{
    public abstract class AbstractUser : AbstractTableEntity, IAbstractUser
    {
        private string _firstName;
        private string _lastName;
        private string _userName;
        private string _emailAddress;
        private string _salt;
        private string _password;

        protected AbstractUser()
        {
            this._firstName = string.Empty;
            this._lastName = string.Empty;
            this._userName = string.Empty;
            this._emailAddress = string.Empty;
            this._salt = string.Empty;
            this._password = string.Empty;
        }
    
        protected AbstractUser(string firstName, string lastName, string userName, string emailAddress, string salt, string password, int id) : base(id)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._userName = userName;
            this._emailAddress = emailAddress;
            this._salt = salt;
            this._password = password;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string UserName
        {
            get => _userName;
            set => _userName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string EmailAddress
        {
            get => _emailAddress;
            set => _emailAddress = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Salt
        {
            get => _salt;
            set => _salt = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Password
        {
            get => _password;
            set => _password = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}