using Flight.DataAccess;
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
    public partial class ListFlightsForm : Form
    {
        ListFlightsPanel panel;
        public ListFlightsForm(ListFlightsPanel panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void ListFlightsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = panel.flights;
        }
    }
}
