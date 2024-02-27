using Otus.Booking.Common.Booking.Contracts.Reservation.Models;

namespace Otus.Booking.Common.Booking.Contracts.Reservation.Responses
{
    public record GetReservationsListResult
    {
        public List<FullReservationDto> Reservations { get; set; }
    }
}
