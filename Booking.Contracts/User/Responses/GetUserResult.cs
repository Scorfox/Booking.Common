using Otus.Booking.Common.Booking.Contracts.User.Models;

namespace Otus.Booking.Common.Booking.Contracts.User.Responses;

/// <summary>
/// Запрос на успешное получение пользователя
/// </summary>
public record GetUserResult : UserGettingDto;