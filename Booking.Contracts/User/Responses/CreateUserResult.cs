using Otus.Booking.Common.Booking.Contracts.User.Models;

namespace Otus.Booking.Common.Booking.Contracts.User.Responses;

/// <summary>
/// Ответ на успешное создание пользователя
/// </summary>
public record CreateUserResult : BaseUserDto
{
    public Guid Id { get; set; }
}