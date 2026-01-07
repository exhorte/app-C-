using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Mapharmacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int pdd = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pdd += 1;
            barDeProgression.Value = pdd;
            chargementlbl.Text = pdd + "%";
            if (barDeProgression.Value == 100)
            {
                barDeProgression.Value = 0;
                timer1.Stop();
                Connexion myCon = new Connexion();
                myCon.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
