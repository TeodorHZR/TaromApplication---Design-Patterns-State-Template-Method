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
    public class LoginPanel : State
    {
        User _user;
        public Form form;
        public  string username;
        public string password;
        public static string u;
        public static string p;
        public int userId;
        public LoginPanel()
        {
            Id = 1;
           
        }
        public override void Display()
        {
            form.ShowDialog();
            
        }


        public override bool IsCorrect()
        {
            if (username == null || password == null)
            {
                Choice = 2;
                return true;
            }
            UserRepository userRepository = new UserRepository();
            userId = userRepository.GetID(username,password);
            bool result = false;
            if (userId<0)
            {
                return result;
            }

            User userFromDb = userRepository.Get(userId);
            if (userFromDb != null && userFromDb.Username == _user.Username && userFromDb.Password == _user.Password)
            {
                Choice = 3;
                result = true;
            }
            return result;
            
        }


        public override bool IsFinal() 
        {
            return false;
        }

        public override string Message()
        {
            string message = "Wrong username or password";
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

            u = username;
            p = password;

            _user = new User()
                {
                    Username = username,
                    Password = password
                };

        }
       

    }
}