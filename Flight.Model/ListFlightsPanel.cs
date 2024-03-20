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
    public class ListFlightsPanel : State
    {
        private FlightRepository _flightRepository = new FlightRepository();
        public  List<Flight.DataAccess.Flight> flights;
        
        public Form form;


        public ListFlightsPanel()
        {
            Id = 10;
           _flightRepository = new FlightRepository();
        }
        public override void Display()
        {
            flights = _flightRepository.GetAllFlights().ToList();
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

            string message = "Successful!";
            MessageBox.Show(message);

        }

        public override void Read()
        {
            Choice = 1;
        }


    }
}