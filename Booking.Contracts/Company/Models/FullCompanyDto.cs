namespace Otus.Booking.Common.Booking.Contracts.Company.Models
{
    public record FullCompanyDto:BaseCompanyDto
    {
        public Guid Id { get; set; }
    }
}
