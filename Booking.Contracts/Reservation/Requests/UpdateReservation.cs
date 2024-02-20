using Otus.Booking.Common.Booking.Contracts.Reservation.Models;

namespace Otus.Booking.Common.Booking.Contracts.Reservation.Requests;

/// <summary>
/// Запрос на обновление брони
/// </summary>
public record UpdateReservation : BaseReservationDto
{
    public Guid Id { get; set; }
}