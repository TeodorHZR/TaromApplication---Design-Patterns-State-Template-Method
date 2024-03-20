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
    public partial class HelpForm : Form
    {
        HelpPanel panel;
        public HelpForm(HelpPanel panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Login: Authenticate a user's credentials to grant access to the system.\r\nAdd flights (admin): Allow administrators to create new flight records in the system.\r\nModify flights (admin): Allow administrators to update existing flight records in the system.\r\nReserve a flight (admin, client): Allow both administrators and clients to reserve seats on a flight.\r\nPurchase a flight (admin, client): Allow both administrators and clients to purchase reserved seats on a flight.\r\nSearch for a flight (admin, client): Allow both administrators and clients to search for flight records in the system based on various search criteria.\r\nList flights: Display a list of all available flight records in the system.\r\nReserve a seat on a flight: Allow clients to reserve a specific seat on a flight.\r\nHelp/info: Provide a brief description of the system's functionalities.\r\nDelete a flight (admin): Allow administrators to delete existing flight records from the system.\r\nExit: Allow users to exit the system.\r\nRegister/create an account (admin, client): Allow both administrators and clients to create a new account in the system.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
