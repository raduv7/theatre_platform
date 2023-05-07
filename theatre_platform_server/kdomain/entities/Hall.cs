using theatre_platform_server.kdomain.interfaces.entities;

namespace theatre_platform_server.kdomain.entities
{
    public class Hall : AbstractTableEntity, IHall
    {
        private string _name;
        private ITheatre _theatre;
        
        public Hall()
        {
            _name = "";
            _theatre = null;
        }

        public Hall(int id, string name, ITheatre theatre) : base(id)
        {
            _name = name;
            _theatre = theatre;
        }
        
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        
        public ITheatre Theatre
        {
            get => _theatre;
            set => _theatre = value;
        }
    }
}