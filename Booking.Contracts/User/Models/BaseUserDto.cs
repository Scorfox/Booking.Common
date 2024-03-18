namespace Otus.Booking.Common.Booking.Contracts.User.Models;

public abstract record BaseUserDto
{
    public Guid? CompanyId { get; set; }
    
    public string Email { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    
    public string PhoneNumber { get; set; }
    
    public Guid RoleId { get; set; }
}