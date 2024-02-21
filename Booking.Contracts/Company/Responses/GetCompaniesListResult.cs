using Otus.Booking.Common.Booking.Contracts.Company.Models;

namespace Otus.Booking.Common.Booking.Contracts.Company.Responses
{
    public record GetCompaniesListResult
    {
        public List<FullCompanyDto> Companies { get; set; }
    }
}
