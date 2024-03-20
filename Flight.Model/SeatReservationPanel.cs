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
    public class SeatReservationPanel : State
    {
        
        private readonly FlightSeatRepository _flightSeatRepository;
       
        FlightSeat flightSeat;
        public int id;
        public Form form;
        public int seatid;
        public SeatReservationPanel()
        {

            Id = 11;
            _flightSeatRepository = new FlightSeatRepository();


        }
        public override void Display()
        {
            id = ReservationPanel.flightid;
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
            _flightSeatRepository.Update(flightSeat);
            Choice = 1;
        }

        public override void Read()
        {
            flightSeat = new FlightSeat()
            {
                FlightId = id,
                SeatId = seatid,
                IsFree = 0
            };
        }


    }
}