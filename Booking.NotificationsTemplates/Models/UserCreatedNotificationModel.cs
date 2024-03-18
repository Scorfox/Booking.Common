namespace Otus.Booking.Common.Booking.NotificationsTemplates.Models
{
    public record UserCreatedNotificationModel
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
    }
}
