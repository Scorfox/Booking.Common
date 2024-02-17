using Otus.Booking.Common.Booking.Contracts.Company.Models;

namespace Otus.Booking.Common.Booking.Contracts.Company.Responses;

/// <summary>
/// Ответ на успешное обновление компании
/// </summary>
public record UpdateCompanyResult : BaseCompanyDto
{
    public Guid Id { get; set; }
}