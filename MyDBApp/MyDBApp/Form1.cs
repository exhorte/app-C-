using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using System.Data;

namespace MyDBApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            string conString = "server=localhost;port=3306;uid=root;pwd=pass;database=testdb;";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string query = "SELECT * FROM employee";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
    }

}
