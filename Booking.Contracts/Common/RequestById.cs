﻿namespace Otus.Booking.Common.Booking.Contracts.Common;

public abstract record RequestById
{
    public Guid Id { get; set; }
}