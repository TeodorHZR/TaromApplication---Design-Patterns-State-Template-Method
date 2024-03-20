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
    public partial class RegisterForm : Form
    {
        public RegisterPanel panel;
        public RegisterForm(RegisterPanel panel)
        {
            InitializeComponent();
            this.panel= panel;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter a username and password");
                return;
            }
            panel.username = textBox1.Text;
            panel.password = textBox2.Text;
            this.Close();
        }
    }
}
