namespace Otus.Booking.Common.Booking.Contracts.Reservation.Models
{
    public record FullReservationDto:BaseReservationDto
    {
        public Guid Id { get; set; }
    }
}
