using Otus.Booking.Common.Booking.Contracts.Authentication.Models;

namespace Otus.Booking.Common.Booking.Contracts.Authentication.Responses;

/// <summary>
/// Ответ на успешное создание пользователя
/// </summary>
public record CreateUserResult : BaseUserDto
{
    public Guid Id { get; set; }
}