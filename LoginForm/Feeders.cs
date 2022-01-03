using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginForm
{
    public partial class Feeders : Form
    {
        string connectionString = "server=localhost;username=root;password=root;database=catfeeder";
        public Feeders()
        {
            InitializeComponent();
        }

        private void ReturnFromFeddersList_Click(object sender, EventArgs e)
        {
            
        }

        private void populateDG_Click(object sender, EventArgs e)
        {
                MySqlCommand cmd;
                MySqlDataAdapter da;
                DataTable dt;
                MySqlConnection con = new MySqlConnection("server=localhost;username=root;password=root;database=catfeeder");
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM `feeders`";
                con.Open();    
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            con.Close();
         }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

 
}
