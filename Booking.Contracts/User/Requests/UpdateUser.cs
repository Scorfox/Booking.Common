using Otus.Booking.Common.Booking.Contracts.User.Models;

namespace Otus.Booking.Common.Booking.Contracts.User.Requests;

/// <summary>
/// Запрос на обновление пользователя
/// </summary>
public record UpdateUser : BaseUserDto
{
    public Guid Id { get; set; }
}