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
    public class ModifyPanel : State
    {
        private readonly FlightRepository _flightRepository;
        Flight.DataAccess.Flight _flight;
        public Form form;
        public string From;
        public string To;
        public DateTime date;
        public decimal price;
        public int id;
        public ModifyPanel()
        {
            Choice = 1;
            Id = 5;
            _flightRepository = new FlightRepository();
        }
        public override void Display()
        {
           
            form.ShowDialog();

        }


        public override bool IsCorrect()
        {
            return (_flightRepository.FlightExistsById(_flight.FlightId));

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
            _flightRepository.Update(_flight);
            string message = "Successful!";
            MessageBox.Show(message);

        }

        public override void Read()
        {
            _flight = new DataAccess.Flight()
            {   FlightId = id,
                From = From,
                To = To,
                Date = date,
                Price = price
            };
        }


    }
}