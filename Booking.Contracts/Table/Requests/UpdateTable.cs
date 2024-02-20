using Otus.Booking.Common.Booking.Contracts.Table.Models;

namespace Otus.Booking.Common.Booking.Contracts.Table.Requests;

/// <summary>
/// Запрос на обновление стола
/// </summary>
public record UpdateTable : BaseTableDto
{
    public Guid Id { get; set; }
}