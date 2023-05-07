using theatre_platform_server.kdomain.interfaces.entities;

namespace theatre_platform_server.kdomain.entities
{
    public class Theatre : AbstractTableEntity, ITheatre
    {
        private string _name;
        private string _address;
        private int _establishementYear;

        public Theatre()
        {
            _name = "";
            _address = "";
            _establishementYear = 0;
        }
        
        public Theatre(string name, string address, int establishementYear, int id) : base(id)
        {
            _name = name;
            _address = address;
            _establishementYear = establishementYear;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        
        public string Address
        {
            get => _address;
            set => _address = value;
        }
        
        public int EstablishmentYear
        {
            get => _establishementYear;
            set => _establishementYear = value;
        }
    }
}