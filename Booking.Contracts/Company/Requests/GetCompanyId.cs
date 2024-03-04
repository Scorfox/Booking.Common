using System.Collections.Generic;

namespace Otus.Booking.Common.Booking.Contracts.Company.Requests
{
    public record GetCompanyId
    {
        public Guid Id { get; set; }
    }
}
