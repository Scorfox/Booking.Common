namespace Otus.Booking.Common.Booking.Notifications.Models;

public class ReservationStatusNotification
{
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FilialName { get; set; }
    public string Address { get; set; }
    public string TableName { get; set; }
    public int Persons { get; set; }
    public ReservationStatus Status { get; set; }
}