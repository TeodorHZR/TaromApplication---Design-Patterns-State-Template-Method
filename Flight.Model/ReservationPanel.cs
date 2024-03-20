using Flight.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Flight.Model
{
    public class ReservationPanel : State
    {
        private readonly UserRepository _userRepository;
        private readonly FlightReservationRepository _flightreservationRepository;
        private readonly FlightRepository flightRepository;
        Flight.DataAccess.Flight _flight;
        FlightReservation flightReservation;
        public static string username;
        public static string password;
        public int id;
        public static int flightid;
        public Form form;
        public int userid;
        public ReservationPanel()
        {
            
            Id = 7;
            _flightreservationRepository = new FlightReservationRepository();
            flightRepository = new FlightRepository();
            _userRepository = new UserRepository();

        }
        public override void Display()
        {

            form.ShowDialog();

        }


        public override bool IsCorrect()
        {
            return (flightRepository.FlightExistsById(_flight.FlightId));

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
            username = LoginPanel.u;
            password = LoginPanel.p;
            int userid = _userRepository.GetID(username, password);
            _flight = flightRepository.Get(id);
            DateTime expirationdate = _flight.Date.AddDays(7);
            flightReservation = new FlightReservation()
            {
                UserId = userid,
                FlightId = _flight.FlightId,
                Date = _flight.Date,
                ExpirationDate = expirationdate

            };
            _flightreservationRepository.Create(flightReservation);
            Choice = 1;
            flightid= _flight.FlightId;
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