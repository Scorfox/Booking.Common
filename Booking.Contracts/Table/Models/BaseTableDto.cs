namespace Otus.Booking.Common.Booking.Contracts.Table.Models;

public abstract record BaseTableDto
{
    public Guid FilialId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int SeatsNumber { get; set; }
}