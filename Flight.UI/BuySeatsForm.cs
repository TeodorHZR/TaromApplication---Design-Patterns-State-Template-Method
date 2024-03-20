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
    public partial class BuySeatsForm : Form
    {
        BuySeatsPanel panel;
        public BuySeatsForm(BuySeatsPanel panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void BuySeatsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel.flightid = Convert.ToInt32(textBox1.Text);
            panel.seatid = Convert.ToInt32(textBox2.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            this.Close();
        }
    }
}
