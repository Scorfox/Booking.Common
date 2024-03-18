using Otus.Booking.Common.Booking.Contracts.Common;

namespace Otus.Booking.Common.Booking.Contracts.Reservation.Requests;

/// <summary>
/// Запрос на получение бронирования
/// </summary>
public record GetReservationById : RequestById
{
    public Guid CompanyId { get; set; }
}

