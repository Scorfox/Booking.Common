using Otus.Booking.Common.Booking.Contracts.Filial.Models;

namespace Otus.Booking.Common.Booking.Contracts.Filial.Requests;

/// <summary>
/// Запрос на обновление филиала
/// </summary>
public record UpdateFilial : BaseFilialDto
{
    public Guid Id { get; set; }
}