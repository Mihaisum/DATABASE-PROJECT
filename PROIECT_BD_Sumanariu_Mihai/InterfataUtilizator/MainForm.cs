using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;
using InterfataUtilizator;

namespace DotNetOracle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStadioane_Click(object sender, EventArgs e)
        {
            FormaAfisare stadioane = new FormaAfisare();
            stadioane.Show();
            //this.Hide();
        }

        private void btnMeciuri_Click(object sender, EventArgs e)
        {
            MECIURI meciuri = new MECIURI();
            meciuri.Show();
            //this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SPECTATOR spectatori = new SPECTATOR();
            spectatori.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
