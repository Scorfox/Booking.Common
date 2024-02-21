namespace Otus.Booking.Common.Booking.Contracts.User.Requests
{
    public record GetUsersList
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
