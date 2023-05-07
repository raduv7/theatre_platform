namespace theatre_platform_server.kdomain.interfaces.entities
{
    public interface IShow : IAbstractTableEntity
    {
        IHall Hall { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime Showtime { get; set; }
        TimeSpan Runtime { get; set; }
        float PriceFactor { get; set; }
        float PromotionPriceFactor { get; set; }
    }
}