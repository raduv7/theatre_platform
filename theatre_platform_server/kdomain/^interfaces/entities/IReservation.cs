namespace theatre_platform_server.kdomain.interfaces.entities
{
    public interface IReservation : IAbstractTableEntity
    {
        ISpectator Spectator { get; set; }
        IShow Show { get; set; }
        ISeats Seats { get; set; }
        int SeatsCount { get; set; }
        float PricePerSeat { get; set; } // only two decimal places
    }
}