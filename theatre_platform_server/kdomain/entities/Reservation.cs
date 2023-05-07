using theatre_platform_server.kdomain._interfaces.entities;

namespace theatre_platform_server.kdomain.entities
{
    public class Reservation : AbstractTableEntity, IReservation
    {
        private ISeats _seats;
        private IShow _show;
        private ISpectator _spectator;
        private int _seatsCount;
        private float _pricePerSeat; // only two decimal places
        
        public Reservation()
        {
            _seats = null!;
            _show = null!;
            _spectator = null!;
            _seatsCount = 0;
            _pricePerSeat = 0;
        }
        
        public Reservation(int id, ISeats seats, IShow show, ISpectator spectator, int seatsCount, float pricePerSeat) : base(id)
        {
            _seats = seats;
            _show = show;
            _spectator = spectator;
            _seatsCount = seatsCount;
            _pricePerSeat = pricePerSeat;
        }
        
        public ISeats Seats
        {
            get => _seats;
            set => _seats = value;
        }
        
        public IShow Show
        {
            get => _show;
            set => _show = value;
        }
        
        public ISpectator Spectator
        {
            get => _spectator;
            set => _spectator = value;
        }
        
        public int SeatsCount
        {
            get => _seatsCount;
            set => _seatsCount = value;
        }
        
        public float PricePerSeat
        {
            get => _pricePerSeat;
            set => _pricePerSeat = value;
        }
    }
}