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
    public class HelpPanel : State
    {
        public Form form;

        public HelpPanel()
        {
            Id = 11;
          
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
            Choice = 1;
            string message = "Successful!";
            MessageBox.Show(message);

        }

        public override void Read()
        {
            
        }


    }
}