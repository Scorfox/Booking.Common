namespace Otus.Booking.Common.Booking.Notifications.Models;

public record ReservationCreatedNotification
{
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FilialName { get; set; }
    public string Address { get; set; }
    public string TableName { get; set; }
    public int PersonsCount { get; set; }
    public string From { get; set; }
    public string To { get; set; }
}