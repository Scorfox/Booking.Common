using Otus.Booking.Common.Booking.Contracts.Common;

namespace Otus.Booking.Common.Booking.Contracts.Filial.Requests;

/// <summary>
/// Запрос на удаление филиала
/// </summary>
public record DeleteFilial : RequestById
{
    public Guid CompanyId { get; set; }
}