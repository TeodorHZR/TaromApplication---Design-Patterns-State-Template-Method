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
    public class BuySeatsPanel : State
    {
        private readonly UserRepository _userRepository;
        private readonly FlightSeatRepository _flightSeatRepository;
        FlightReservation flightReservation;
        FlightSeat flightSeat;
        public static string username;
        public static string password;
        public int userid;
        public int flightid;
        public Form form;
        public int seatid;
        public BuySeatsPanel()
        {
            
            Id = 8;
            _flightSeatRepository = new FlightSeatRepository();
            _userRepository = new UserRepository();
        }
        public override void Display()
        {

            form.ShowDialog();

        }


        public override bool IsCorrect()
        {
            return (_flightSeatRepository.IsSeatFree(seatid));

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
            userid = _userRepository.GetID(username, password);
            _flightSeatRepository.Update(flightSeat);
            _flightSeatRepository.BookSeat(userid, flightid,seatid);
            Choice = 1;
            string message = "Successful!";
            MessageBox.Show(message);
        }

        public override void Read()
        {
            flightSeat = new FlightSeat()
            {
                FlightId = flightid,
                SeatId = seatid,
                IsFree = 0
            };
        }


    }
}