using theatre_platform_server.kdomain._interfaces.entities;

namespace theatre_platform_server.kdomain.entities
{
    public class Show : AbstractTableEntity, IShow
    {
        private IHall _hall;
        private string _name;
        private string _description;
        private DateTime _showtime;
        private TimeSpan _runtime;
        private float _priceFactor;
        private float _promotionPriceFactor;
        
        public Show()
        {
            _hall = null!;
            _name = "";
            _description = "";
            _showtime = new DateTime();
            _runtime = new TimeSpan();
            _priceFactor = 0;
            _promotionPriceFactor = 0;
        }

        public Show(int id, IHall hall, string name, string description, DateTime showtime, TimeSpan runtime, float priceFactor, float promotionPriceFactor) : base(id)
        {
            _hall = hall;
            _name = name;
            _description = description;
            _showtime = showtime;
            _runtime = runtime;
            _priceFactor = priceFactor;
            _promotionPriceFactor = promotionPriceFactor;
        }
        
        public IHall Hall
        {
            get => _hall;
            set => _hall = value;
        }
        
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        
        public string Description
        {
            get => _description;
            set => _description = value;
        }
        
        public DateTime Showtime
        {
            get => _showtime;
            set => _showtime = value;
        }
        
        public TimeSpan Runtime
        {
            get => _runtime;
            set => _runtime = value;
        }
        
        public float PriceFactor
        {
            get => _priceFactor;
            set => _priceFactor = value;
        }
        
        public float PromotionPriceFactor
        {
            get => _promotionPriceFactor;
            set => _promotionPriceFactor = value;
        }
    }
}