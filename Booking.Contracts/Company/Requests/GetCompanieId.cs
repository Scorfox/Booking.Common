﻿using System.Collections.Generic;

namespace Otus.Booking.Common.Booking.Contracts.Company.Requests
{
    public record GetCompanieId
    {
        public Guid Id { get; set; }
    }
}