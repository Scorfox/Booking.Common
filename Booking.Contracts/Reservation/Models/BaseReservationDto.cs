﻿namespace Otus.Booking.Common.Booking.Contracts.Reservation.Models;

public abstract record BaseReservationDto
{
    public Guid CompanyId { get; set; }
    public Guid TableId { get; set; }
    public Guid FilialId { get; set; }
    public Guid WhoBookedId { get; set; }
    public Guid? WhoConfirmedId { get; set; }
    public Guid? WhoCancelledId { get; set; }
    
    public DateTimeOffset From { get; set; }
    public DateTimeOffset To { get; set; }
}