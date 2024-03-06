using Otus.Booking.Common.Booking.Contracts.Common;
using Otus.Booking.Common.Booking.Contracts.Company.Models;

namespace Otus.Booking.Common.Booking.Contracts.Company.Responses
{
    public record GetCompaniesListResult : ListedResponse<FullCompanyDto>;
}
