using Otus.Booking.Common.Booking.Contracts.Reservation.Models;

namespace Otus.Booking.Common.Booking.Contracts.Reservation.Responses;

/// <summary>
/// Ответ на успешное получение бронирования
/// </summary>
public record GetReservationResult : ReservationGettingDto;