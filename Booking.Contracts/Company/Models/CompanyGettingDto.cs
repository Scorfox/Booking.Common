namespace Otus.Booking.Common.Booking.Contracts.Company.Models;

public record CompanyGettingDto : BaseCompanyDto
{
    public Guid Id { get; set; }
}