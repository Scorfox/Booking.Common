using Otus.Booking.Common.Booking.Contracts.Common;
using Otus.Booking.Common.Booking.Contracts.Reservation.Models;

namespace Otus.Booking.Common.Booking.Contracts.Reservation.Responses
{
    public record GetReservationsListResult : ListedResponse<FullReservationDto>;
}
