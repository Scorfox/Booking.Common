namespace Otus.Booking.Common.Booking.Notifications.Models;

public record UserCreatedNotification
{
    public string Email { get; set; }
    public string Login { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}