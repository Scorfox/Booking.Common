namespace Otus.Booking.Common.Booking.Contracts.Filial.Models;

public abstract record BaseFilialDto
{
    public Guid CompanyId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string? Description { get; set; }
}