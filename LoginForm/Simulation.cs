using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Simulation : Form
    {
        public Boolean simulationOn = false; 
        public Simulation()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            simulationOn = true;
            int simulationDays = 0;

            int maxFood = 5000;
            int portion = 250;
            while (simulationOn && maxFood > 0)
            {
                simulationDays++;
                this.days.Text = "Days: " + simulationDays.ToString();
                maxFood -= portion;
                this.food.Text = "Food: " + maxFood.ToString();
                await Task.Delay(1000);
                this.Refresh();
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization auth = new Authorization();
            auth.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void days_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            simulationOn = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
