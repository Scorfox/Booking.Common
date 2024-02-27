namespace Otus.Booking.Common.Booking.Contracts.Notification.Models;

public abstract record BaseTemplateDto
{
    public string Subjecte { get; set; }
    public string Body { get; set;}
}