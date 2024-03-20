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
    public partial class AddForm : Form
    {
        public AddPanel panel;
        public AddForm(AddPanel panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel.From = textBox1.Text;
            panel.To = textBox2.Text;
            panel.date = Convert.ToDateTime(textBox3.Text);
            panel.price = Convert.ToDecimal(textBox4.Text);

            this.Close();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
