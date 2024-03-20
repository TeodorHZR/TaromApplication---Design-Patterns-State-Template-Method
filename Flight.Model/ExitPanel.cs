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
    public class ExitPanel : State
    {

        public ExitPanel()
        {
            Id = 12;

        }
        public override void Display()
        {


        }


        public override bool IsCorrect()
        {
            return true;

        }


        public override bool IsFinal()
        {
            return true;
        }

        public override string Message()
        {
            string message = "Wrong!";
            MessageBox.Show(message);
            return message;
        }
        public override void Process()
        {
            Choice = 1;
            string message = "Exit!";
            MessageBox.Show(message);

        }

        public override void Read()
        {

        }


    }
}