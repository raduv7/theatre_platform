using theatre_platform_server.kdomain.entities.enums;

namespace theatre_platform_server.kdomain.interfaces.entities
{
    public interface ISeats : IAbstractTableEntity
    {
        int SeatCount { get; set; }
        ESeatType SeatType { get; set; }
        IHall Hall { get; set; }
    }
}