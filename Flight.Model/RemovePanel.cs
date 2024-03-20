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
    public class RemovePanel : State
    {
        private readonly FlightRepository _flightRepository;
        private readonly FlightSeatRepository _flightseatRepository;
        private readonly FlightReservationRepository _flightreservationRepository;
        Flight.DataAccess.Flight _flight;
        public Form form;
        public int id;
        public RemovePanel()
        {
            Choice = 1;
            Id = 6;
            _flightRepository = new FlightRepository();
            _flightreservationRepository = new FlightReservationRepository();
            _flightseatRepository = new FlightSeatRepository();
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
            _flightseatRepository.DeleteByFlightId(_flight.FlightId);
            _flightreservationRepository.Delete(_flight.FlightId);
            _flightRepository.Delete(_flight.FlightId);
            string message = "Successful!";
            MessageBox.Show(message);

        }

        public override void Read()
        {
            _flight = new DataAccess.Flight()
            {
                FlightId = id,
                
            };
        }


    }
}