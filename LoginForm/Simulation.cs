﻿using System;
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

        DateTime simulationDays = DateTime.Now;

        int maxFood = 5000;
        int portion = 250;

        private async void start_Click(object sender, EventArgs e)
        {
            simulationOn = true;
           
            while (simulationOn && maxFood > 0)
            {
                simulationDays = simulationDays.AddHours(5);
                this.days.Text = "Time: " + simulationDays.TimeOfDay.ToString();
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


        private void stop_Click(object sender, EventArgs e)
        {
            simulationOn = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
