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
    public partial class ManualHandlingForm : Form
    {
        public ManualHandlingForm()
        {
            InitializeComponent();
        }

        string name;

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void ManualHandlingForm_Load(object sender, EventArgs e)
        {
            feeders.Items.Add("feeder1");
            feeders.Items.Add("feeder2");
            feeders.Items.Add("feeder3");
        }

        private void feeders_SelectedIndexChanged(object sender, EventArgs e)
        {
            name=feeders.SelectedItem.ToString();
            
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string food = food1.Text;
            answer.Text = food + " " + name;

        }

        private void food1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back1_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization auth = new Authorization();
            auth.Show();
        }
    }
}
