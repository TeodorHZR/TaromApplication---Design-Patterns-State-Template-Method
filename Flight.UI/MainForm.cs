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
    public partial class MainForm : Form
    { public string tip;
        public MainPanel panel;
        public bool ok = true;
        public MainForm(MainPanel panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            tip = MainPanel.tip;
            if(ok)
            switch (tip)
            {
                case "admin":
                    comboBox1.Items.Add("Adaugare zboruri");
                    comboBox1.Items.Add("Modificare zboruri");
                    comboBox1.Items.Add("Eliminare zbor");
                    comboBox1.Items.Add("Rezervare zbor");
                    comboBox1.Items.Add("Cumparare zbor");
                    comboBox1.Items.Add("Cautare zbor");
                    comboBox1.Items.Add("Lista zboruri");
                    comboBox1.Items.Add("Rezerva loc");
                    comboBox1.Items.Add("Help");
                    comboBox1.Items.Add("Exit");
                    break;
                case "client":
                    comboBox1.Items.Add("Rezervare zbor");
                    comboBox1.Items.Add("Cumparare zbor");
                    comboBox1.Items.Add("Cautare zbor");
                    comboBox1.Items.Add("Lista zboruri");
                    comboBox1.Items.Add("Rezerva loc");
                    comboBox1.Items.Add("Help");
                    comboBox1.Items.Add("Exit");
                    break;
                default:
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            if (tip == "admin")
            {
                x = (int)comboBox1.SelectedIndex + 1;
            }
            else x = (int)comboBox1.SelectedIndex + 4;

            panel.choice = x;
            ok = false;
            this.Close();
        }
    }
}
