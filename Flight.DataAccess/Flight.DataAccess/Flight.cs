using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Flight.DataAccess
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }

}
