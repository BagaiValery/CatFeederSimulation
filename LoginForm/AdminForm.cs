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
    public partial class AdminForm : Form
    {
        NewFedder nf = new NewFedder();
        RegistrateForm rf = new RegistrateForm();
        LogsForm lf = new LogsForm(); 
        Feeders f = new Feeders();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AddFedder_Click(object sender, EventArgs e)
        {
            nf.Show();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            rf.Show();
        }

        private void RevieLogs_Click(object sender, EventArgs e)
        {
            lf.Show();
        }

        private void ListOfFeeders_Click(object sender, EventArgs e)
        {
            f.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization auth = new Authorization();
            auth.Show();
        }
    }
}
