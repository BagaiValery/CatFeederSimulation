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
using Presenter.View;
using Presenter.Presenters;

namespace LoginForm
{

    public partial class Simulation : Form, ISimulation
    {
        SimulationPresenter presenter;
        bool SimStart;
        bool initTime = false;

        MySqlConnection con = new MySqlConnection("server=localhost;username=root;password=root;database=catfeeder");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;

        public Simulation()
        {
            InitializeComponent();
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
                initTime = false;
            }

    }

        private async void start_Click(object sender, EventArgs e)
        {
//            bool success = Int32.TryParse(this.dp.Text, out maxFood);
            presenter.StartSimulation();
            SimStart = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
   //         Authorization auth = new Authorization();
   //         auth.Show();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            presenter.StopSimulation();
            SimStart = false;
        }

        public string FeederText
        {
            get
            {
                return dp.Text;
            }
            set
            {
                dp.Text = value;
            }
        }

        public string BowlText
        {
            get
            {
                return fs.Text;
            }
            set
            {
                fs.Text = value;
            }
        }

        public string MeowText
        {
            get
            {
                return fs.Text;
            }
            set
            {
                fs.Text = value;
            }
        }

        public string FeedingText
        {
            get
            {
                return ManualFeeding.Text;
            }
            set
            {
                ManualFeeding.Text = value;
            }
        }
        public string TimeText
        {
            get
            {
                return Time.Text;
            }
            set
            {
                Time.Text = value;
            }
        }

        public string PortionText
        {
            get
            {
                return portion.Text;
            }
            set
            {
                portion.Text = value;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SimStart)
            {
                presenter.PresentBowl();
                presenter.PresentFeeder();
                presenter.Meow();
                presenter.PresentTime();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.StopSimulation();
            SimStart = false;
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
                        portion.Text = reader["portion"].ToString();
                    }
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
            presenter = new SimulationPresenter(this);
            PortionText = "0";
            FeedingText = "0";
            FeederText = "0";
            BowlText = "0";
        }

        private void label1_Click(object sender, EventArgs e){}

        private void FullFeeder_Click(object sender, EventArgs e)
        {
            presenter.FoolFeeder();
        }

        private void Faster_Click(object sender, EventArgs e)
        {
            presenter.BoostUp();
        }

        private void Slower_Click(object sender, EventArgs e)
        {
            presenter.BoostDown();
        }

        private void FeedNow_Click(object sender, EventArgs e)
        {
            presenter.FeedNow();
        }
    }
}
