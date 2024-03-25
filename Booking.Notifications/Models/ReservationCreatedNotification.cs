namespace Otus.Booking.Common.Booking.Notifications.Models
{
    public class ReservationCreatedNotification
    {
        public string Email { get; set; }
        public string FirastName { get; set; }
        public string LastName { get; set; }
        public string FilialName { get; set; }
        public string Address { get; set; }
        public string TableName { get; set; }
        public int Persons { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }
}
