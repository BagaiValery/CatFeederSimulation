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

    public partial class Simulation : Form
    {
        DateTime simulationDays = DateTime.Now;
        long simulationSeconds = 0;
       int maxFood = 5000;
        int portion = 250;
        long daysOut = 0;
        long hoursOut = 0;
        long minutesOut = 0;
        long secondsOut = 0;
        long lastFeedSeconds = 0;
        bool initTime = false;

        MySqlConnection con = new MySqlConnection("server=localhost;username=root;password=root;database=catfeeder");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;

        public Boolean simulationOn = false; 
        public Simulation()
        {
            InitializeComponent();
            this.timeMult.Value = 1;
            initTime = true;
            try
            {
                con.Close();
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM `feeders`";
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                feedersList.DataSource = dt;
                feedersList.DisplayMember = "feederName";
                feedersList.ValueMember = "feederName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();

            }
            initTime = false;

    }

    private async void start_Click(object sender, EventArgs e)
        {
            simulationOn = true;
            this.food.Text = "Food: " + maxFood.ToString();

            while (simulationOn && maxFood > 0)
            {
                daysOut = (long)((simulationSeconds-(simulationSeconds % 86400)) / 86400);
                hoursOut = (long) ((simulationSeconds % 86400)/3600);
                minutesOut = (long)((simulationSeconds % 3600)/60);
                secondsOut = simulationSeconds % 60;
                this.days.Text = "Days:Hours:Min:Sec: \n" + daysOut + ":" + hoursOut + ":"+minutesOut + ":"+secondsOut;

                simulationSeconds+= this.timeMult.Value;
                if (simulationSeconds - lastFeedSeconds >= 43200)
                {
                    maxFood -= (int)(portion*((simulationSeconds-lastFeedSeconds)/43200));
                    if (maxFood < 0) maxFood = 0;
                    this.food.Text = "Food: " + maxFood.ToString();
                    this.Refresh();
                    lastFeedSeconds = simulationSeconds;
                }
                await Task.Delay(1000);
                this.Refresh();
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
   //         Authorization auth = new Authorization();
    //        auth.Show();
        }


        private void stop_Click(object sender, EventArgs e)
        {
            simulationOn = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            simulationSeconds = 0;
            this.days.Text = "Days:Hours:Min:Sec: \n" + 0 + ":" + 0 + ":" + 0 + ":" + 0;
            if (initTime) return;
            try
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand("SELECT `maxFood`, `portion` FROM `feeders` WHERE `feederName` = '" + feedersList.Text+"'", con))
                {
                    cmd.Parameters.AddWithValue("@feederName", feedersList.Text);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dp.Text = reader["maxFood"].ToString();
                        fs.Text = reader["portion"].ToString();

                    }

                    bool success  = Int32.TryParse(this.fs.Text, out portion);
                    success = Int32.TryParse(this.dp.Text, out maxFood);
                    this.food.Text = "Food: " + maxFood.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();

            }

        }

        private void Simulation_Load(object sender, EventArgs e)
        {

        }

        private void FeddersList_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dp_TextChanged(object sender, EventArgs e)
        {
            bool success = Int32.TryParse(this.dp.Text, out maxFood);
            this.food.Text = "Food: " + maxFood.ToString();
            simulationSeconds = 0;
            this.days.Text = "Days:Hours:Min:Sec: \n" + 0 + ":" + 0 + ":" + 0 + ":" + 0;
            this.Refresh();
        }

        private void timeMult_TextChanged(object sender, EventArgs e)
        {

        }

        private void fs_TextChanged(object sender, EventArgs e)
        {
            bool success = Int32.TryParse(this.fs.Text, out portion);
            this.Refresh();
        }

        private void FullFeeder_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.tm.Text = "Time Increment: " + this.timeMult.Value;
        }

        private void tm_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
