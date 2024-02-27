using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.Booking.Common.Booking.Contracts.Reservation.Requests
{
    public record GetReservationsList
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
