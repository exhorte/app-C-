using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mapharmacy
{
    public partial class Fabricant : Form
    {
        public Fabricant()
        {
            InitializeComponent();
        }

       

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exhor\OneDrive\文档\mapharmacy.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (NomTb.Text == "" || AddTb.Text == "" || DescTb.Text == "" || TelTb.Text == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs");
                MessageBox.Show("Veuillez remplir tout les champs");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Req = "insert into FabricantTbl value('"+NomTb.Text + "','" + AddTb.Text + "','" + DescTb.Text + "','" + TelTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(Req, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fabricant ajouter aec success");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NomTb.Text = string.Empty;
            AddTb.Text = string.Empty;
            DescTb.Text = string.Empty;
            TelTb.Text = string.Empty;
            NomTb.Focus();
        }
    }
}

