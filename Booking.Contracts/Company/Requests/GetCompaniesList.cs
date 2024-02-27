﻿using System.Collections.Generic;

namespace Otus.Booking.Common.Booking.Contracts.Company.Requests
{
    public record GetCompaniesList
    {
        private int _offset;
        private int _limit;

        public int Offset
        {
            get => _offset;
            set => _offset = value;
        }

        public int Limit
        {
            get => _limit;
            set => _limit = value;
        }

        public int PageSize
        {
            get { return Limit; }
            set { _limit = value; }
        }

        public int PageNumber
        {
            get { return (int)Math.Floor((double)(Offset / Limit)) + 1; }
            set { _offset = value * Limit; }
        }
    }
}
