using Otus.Booking.Common.Booking.Contracts.Notification.Models;

namespace Otus.Booking.Common.Booking.Contracts.Notification.Responses
{
    public record GetCompaniesListResult : BaseTemplateDto
    {
        public Guid Id { get; set; }
    }
}
