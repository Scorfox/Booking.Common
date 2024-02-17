namespace Otus.Booking.Common.Booking.Contracts.Company.Models;

public abstract record BaseCompanyDto
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Inn { get; set; }
    public string MainAddress { get; set; }
}