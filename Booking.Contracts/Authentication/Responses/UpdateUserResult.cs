using Otus.Booking.Common.Booking.Contracts.Authentication.Models;

namespace Otus.Booking.Common.Booking.Contracts.Authentication.Responses;

/// <summary>
/// Ответ на успешное обнолвление пользователя
/// </summary>
public record UpdateUserResult : BaseUserDto
{
    public Guid Id { get; set; }
}