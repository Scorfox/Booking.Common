using Otus.Booking.Common.Booking.Contracts.Authentication.Models;

namespace Otus.Booking.Common.Booking.Contracts.Authentication.Requests;

/// <summary>
/// Запрос на обновление пользователя
/// </summary>
public record UpdateUser : BaseUserDto
{
    public Guid Id { get; set; }
}