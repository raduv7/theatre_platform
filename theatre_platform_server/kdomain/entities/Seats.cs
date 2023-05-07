using theatre_platform_server.kdomain.entities.enums;
using theatre_platform_server.kdomain.interfaces.entities;

namespace theatre_platform_server.kdomain.entities
{
    public class Seats : AbstractTableEntity, ISeats
    {
        private IHall _hall;
        private ESeatType _seatType;
        private int _seatCount;
        
        public Seats()
        {
            _hall = null!;
            _seatType = ESeatType.None;
            _seatCount = 0;
        }

        public Seats(int id, IHall hall, ESeatType seatType, int seatCount) : base(id)
        {
            _hall = hall;
            _seatType = seatType;
            _seatCount = seatCount;
        }
        
        public IHall Hall
        {
            get => _hall;
            set => _hall = value;
        }
        
        public ESeatType SeatType
        {
            get => _seatType;
            set => _seatType = value;
        }
        
        public int SeatCount
        {
            get => _seatCount;
            set => _seatCount = value;
        }
    }
}