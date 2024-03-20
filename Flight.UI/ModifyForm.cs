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
    public partial class ModifyForm : Form
    {
        public ModifyPanel panel= new ModifyPanel();
        public ModifyForm(ModifyPanel panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel.id = Convert.ToInt32(textBox5.Text);
            panel.From = textBox1.Text;
            panel.To = textBox2.Text;
            panel.date = Convert.ToDateTime(textBox3.Text);
            panel.price = Convert.ToDecimal(textBox4.Text);

            this.Close();
        }
    }
}
