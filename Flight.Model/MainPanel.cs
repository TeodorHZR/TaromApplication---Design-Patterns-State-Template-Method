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
    public class MainPanel : State
    {
        private readonly UserRepository _userRepository;
        public Form form;
        public static string username;
        public static string password;
        public static string tip;
        public int choice;
        public MainPanel()
        {
            Id = 3;
            _userRepository = new UserRepository();
        }
        public override void Display()
        {
            username = LoginPanel.u;
            password = LoginPanel.p;
            int id = _userRepository.GetID(username,password);
            tip = _userRepository.GetUserTypeById(id);
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
            Choice = choice;
        }


    }
}