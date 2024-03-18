using Otus.Booking.Common.Booking.Contracts.Common;

namespace Otus.Booking.Common.Booking.Contracts.Reservation.Requests;

/// <summary>
/// Запрос на получение бронирований с пагинацией
/// </summary>
public record GetReservationsList : RequestByPagination
{
    public Guid FilialId { get; set; }
}