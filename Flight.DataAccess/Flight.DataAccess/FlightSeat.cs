using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.DataAccess
{
    public class FlightSeat
    {
        public int SeatId { get; set; }
        public int FlightId { get; set; }
        public int IsFree { get; set; }
    }
}