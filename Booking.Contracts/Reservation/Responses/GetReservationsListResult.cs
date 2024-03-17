using Otus.Booking.Common.Booking.Contracts.Common;
using Otus.Booking.Common.Booking.Contracts.Reservation.Models;

namespace Otus.Booking.Common.Booking.Contracts.Reservation.Responses;

/// <summary>
/// Ответ на успешное получение бронирований с пагинацией
/// </summary>
public record GetReservationsListResult : ResponseByPagination<ReservationGettingDto>;