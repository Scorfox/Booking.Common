using Otus.Booking.Common.Booking.Contracts.Common;

namespace Otus.Booking.Common.Booking.Contracts.User.Requests;

/// <summary>
/// Запрос на получение пользователей (клиентов/админов) с пагинацией
/// </summary>
public record GetUsersList : RequestByPagination
{
    public Guid RoleId { get; set; }
}