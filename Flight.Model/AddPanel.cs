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
    public class AddPanel : State
    {
        Flight.DataAccess.Flight _flight;
        private readonly FlightRepository _flightRepository;
        public Form form;

        public string From;
        public string To;
        public DateTime date;
        public decimal price;
        public AddPanel()
        {
            Choice = 1;
            Id = 4;
            _flightRepository = new FlightRepository();
        }
        public override void Display()
        {
            
            form.ShowDialog();

        }


        public override bool IsCorrect()
        {
            return (!_flightRepository.FlightExists(From, To, date, price));

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
            _flightRepository.Create(_flight);
            string message = "Successful!";
            MessageBox.Show(message);

        }

        public override void Read()
        {
            _flight = new DataAccess.Flight() { From = From,
            To = To,
            Date = date,
            Price = price};
        }


    }
}