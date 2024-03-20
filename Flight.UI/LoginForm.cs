using Flight.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight.UI
{
    public partial class LoginForm : Form
    {

        public LoginPanel loginPanel;

        public LoginForm(LoginPanel panel)
        {
            InitializeComponent();
            loginPanel = panel;
        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LoginPanel.username = textBox_Username.Text;
            //LoginPanel.password = textBox_Password.Text;
            //Program.loginPanel
            if (string.IsNullOrEmpty(textBox_Username.Text) || string.IsNullOrEmpty(textBox_Password.Text))
            {
                MessageBox.Show("Please enter a username and password");
                return;
            }
            loginPanel.username = textBox_Username.Text;
            loginPanel.password = textBox_Password.Text;
            this.Close();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
