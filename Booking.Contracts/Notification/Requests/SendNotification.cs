namespace Otus.Booking.Common.Booking.Contracts.Notification.Requests
{
    public record SendNotification
    {
        public string ToEmail { get; set; }
        public Guid TemplateId { get; set; }
    }
}
