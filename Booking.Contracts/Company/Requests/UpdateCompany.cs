using Otus.Booking.Common.Booking.Contracts.Company.Models;

namespace Otus.Booking.Common.Booking.Contracts.Company.Requests;

/// <summary>
/// Запрос на обновление компании
/// </summary>
public record UpdateCompany : BaseCompanyDto
{
    public Guid Id { get; set; }
}