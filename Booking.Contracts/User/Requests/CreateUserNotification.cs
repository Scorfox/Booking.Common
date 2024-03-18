namespace Otus.Booking.Common.Booking.Contracts.User.Requests
{
    public record CreateUserNotification
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
