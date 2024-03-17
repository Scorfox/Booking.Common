namespace Otus.Booking.Common.Booking.Contracts.Reservation.Models;

public record ReservationGettingDto : BaseReservationDto
{
    public Guid Id { get; set; }
}