using System.Collections.Generic;

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
    }
}
