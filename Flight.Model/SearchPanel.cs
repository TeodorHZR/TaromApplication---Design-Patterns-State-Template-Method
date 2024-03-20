using Flight.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Flight.Model
{
    public class SearchPanel : State
    {
        private FlightRepository _flightRepository = new FlightRepository();
        private FlightSeatRepository flightSeatRepository= new FlightSeatRepository();
        public Flight.DataAccess.Flight flight;
        public List<Flight.DataAccess.Flight> flights;
        public List<FlightSeat> Seats;
        public Form form;
        public bool ok = false;
        public int choice;
        public int id;

        public SearchPanel()
        {
            Id = 9;
            flightSeatRepository = new FlightSeatRepository();
            _flightRepository = new FlightRepository();
            flights = new List<Flight.DataAccess.Flight>();
        }
        public override void Display()
        {
            
            form.ShowDialog();

        }


        public override bool IsCorrect()
        {
            return true;

        }


        public override bool IsFinal()
        {
            return false;
        }

        public override string Message()
        {
            string message = "Wrong!";
            MessageBox.Show(message);
            return message;
        }
        public override void Process()
        {
            Seats = flightSeatRepository.GetAllSeats(id);
            flight = _flightRepository.Get(id);
            flights.Add(flight);
            form.ShowDialog();
            Choice = choice;
            string message = "Successful!";
            MessageBox.Show(message);
            ok = false;
        }

        public override void Read()
        {
            Choice = choice;
            ok = true;
        }


    }
}