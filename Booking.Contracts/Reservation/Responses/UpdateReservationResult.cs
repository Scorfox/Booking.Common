using Otus.Booking.Common.Booking.Contracts.Reservation.Models;

namespace Otus.Booking.Common.Booking.Contracts.Reservation.Responses;

/// <summary>
/// Ответ на успешное обновление брони 
/// </summary>
public record UpdateReservationResult : BaseReservationDto
{
    public Guid Id { get; set; }
}