namespace Otus.Booking.Common.Booking.Contracts.Common
{
    public abstract record ListedResponse<T>
    {
        public int TotalCount { get; set; }
        public List<T> Elements { get; set; } = new ();
    }
}
