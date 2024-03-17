using Otus.Booking.Common.Booking.Contracts.Reservation.Models;

namespace Otus.Booking.Common.Booking.Contracts.Reservation.Responses;

/// <summary>
/// Ответ на успешное создание брони
/// </summary>
public record CreateReservationResult : ReservationGettingDto;