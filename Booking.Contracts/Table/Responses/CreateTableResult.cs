using Otus.Booking.Common.Booking.Contracts.Table.Models;

namespace Otus.Booking.Common.Booking.Contracts.Table.Responses;

/// <summary>
/// Ответ на успешное создание стола
/// </summary>
public record CreateTableResult : BaseTableDto
{
    public Guid Id { get; set; }
}