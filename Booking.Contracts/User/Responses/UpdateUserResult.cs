using Otus.Booking.Common.Booking.Contracts.User.Models;

namespace Otus.Booking.Common.Booking.Contracts.User.Responses;

/// <summary>
/// Ответ на успешное обнолвление пользователя
/// </summary>
public record UpdateUserResult : BaseUserDto
{
    public Guid Id { get; set; }
}