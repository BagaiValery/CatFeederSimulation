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
    public partial class Authorization : Form
    {
        Simulation sim = new Simulation();
        AdminForm af = new AdminForm();
        AuthUserForm ua = new AuthUserForm();
        RegistrateForm reg = new RegistrateForm();

        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void LoginAdmin_Click(object sender, EventArgs e)
        {
            af.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginUser_Click(object sender, EventArgs e)
        {
            ua.Show();

        }

        private void simulation_Click(object sender, EventArgs e)
        {
            sim.Show();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            reg.Show();
        }
    }
}
