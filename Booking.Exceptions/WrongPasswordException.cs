namespace Otus.Booking.Common.Booking.Exceptions;

public class WrongPasswordException : Exception
{
    public WrongPasswordException(string message) : base(message)
    {
    }
}