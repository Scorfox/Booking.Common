namespace Otus.Booking.Common.Booking.Contracts.Reservation.Requests;

/// <summary>
/// Запрос на подтверждение бронирования
/// </summary>
public record ConfirmReservation
{
    public Guid CompanyId { get; set; }
    public Guid FilialId { get; set; }
    public Guid TableId { get; set; }
    public Guid Id { get; set; }
    public Guid WhoConfirmedId { get; set; }
    
    public DateTimeOffset From { get; set; }
    public DateTimeOffset To { get; set; }
}