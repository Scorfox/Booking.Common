using Otus.Booking.Common.Booking.Contracts.Company.Models;

namespace Otus.Booking.Common.Booking.Contracts.Company.Responses;

/// <summary>
/// Ответ на успешное создание компании
/// </summary>
public record CreateCompanyResult : BaseCompanyDto
{
    public Guid Id { get; set; }
}