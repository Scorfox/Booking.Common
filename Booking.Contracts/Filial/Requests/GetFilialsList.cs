using Otus.Booking.Common.Booking.Contracts.Common;

namespace Otus.Booking.Common.Booking.Contracts.Filial.Requests;

/// <summary>
/// Получение филиалов с пагинацией
/// </summary>
public record GetFilialsList : RequestByPagination
{
    public Guid CompanyId { get; set; }
}