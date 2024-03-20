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
    
    public partial class SearchForm : Form
    {
        public bool ok = false;
        SearchPanel panel;
        public SearchForm(SearchPanel panel)
        {
            this.panel = panel;
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            
            ok = panel.ok;
            if(ok)
            {
                dataGridView1.DataSource = panel.flights;
                dataGridView2.DataSource = panel.Seats;
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView2.DataSource= null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel.id = Convert.ToInt32(textBox1.Text);
            panel.choice = 1;
            textBox1.Text = "";
            this.Close();
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            panel.choice = 2;
            this.Close();
        }
    }
}
