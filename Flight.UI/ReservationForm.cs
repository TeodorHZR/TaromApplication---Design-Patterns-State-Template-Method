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
    public partial class ReservationForm : Form
    {
        ReservationPanel panel; 
        public ReservationForm(ReservationPanel panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel.id = Convert.ToInt32(textBox1.Text);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
