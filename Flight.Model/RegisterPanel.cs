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
    public class RegisterPanel : State
    {
        private readonly UserRepository _userRepository;
        private User _user;
        public Form form;
        public string username;
        public string password;

        public RegisterPanel()
        {
            Id = 2;
            _userRepository = new UserRepository();
        }

        public override void Display()
        {
            form.ShowDialog();
        }

        public override bool IsCorrect()
        {
            if (_userRepository.GetID(username, password) > 0)
            {
                string message = "This Username already exists!";
                MessageBox.Show(message);
                return false;
            }
            return true;
        }

        public override bool IsFinal()
        {
            return false;
        }

        public override string Message()
        {
            string message = "This Username already exists!";
            MessageBox.Show(message);
            return message;
        }

        public override void Process()
        {
            Choice = 1;
                _user = new User()
                {
                    Username = username,
                    Password = password,
                    Tip = "client"
                };
                _userRepository.Create(_user);
                string message = "Successful!";
                MessageBox.Show(message);
            
        }

        public override void Read()
        {
            _user = new User()
            {
                Username = username,
                Password = password,
                Tip = "client"
            };
        }
    }
}
