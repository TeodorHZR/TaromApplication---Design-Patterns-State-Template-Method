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
    public partial class SeatReservationForm : Form
    {
        SeatReservationPanel panel;
        public SeatReservationForm(SeatReservationPanel panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel.seatid = Convert.ToInt32(textBox1.Text);
            this.Close();
        }
    }
}
