using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.DataAccess
{
    public class FlightReservation
    {
        public int UserId { get; set; }
        public int FlightId { get; set; }
        public DateTime Date { get; set; }
        public DateTime ExpirationDate { get; set; }
    }

}
