using Otus.Booking.Common.Booking.Contracts.Common;
using Otus.Booking.Common.Booking.Contracts.User.Models;

namespace Otus.Booking.Common.Booking.Contracts.User.Responses;

/// <summary>
/// Ответ на успешное получение пользователей (клиентов/админов)
/// </summary>
public record GetUsersListResult : ResponseByPagination<UserGettingDto>;