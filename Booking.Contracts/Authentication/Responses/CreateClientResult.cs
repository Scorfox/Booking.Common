using Otus.Booking.Common.Booking.Contracts.Authentication.Models;

namespace Otus.Booking.Common.Booking.Contracts.Authentication.Responses;

/// <summary>
/// Ответ на успешное создание клиента
/// </summary>
public record CreateClientResult : BaseClientDto
{
    public Guid Id { get; set; }
}