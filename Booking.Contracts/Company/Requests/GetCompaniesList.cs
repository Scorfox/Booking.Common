namespace Otus.Booking.Common.Booking.Contracts.Company.Requests
{
    public record GetCompaniesList
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
