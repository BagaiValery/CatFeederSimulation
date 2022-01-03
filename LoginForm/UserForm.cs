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
    public partial class UserForm : Form
    {


        Feeders f = new Feeders();


        public UserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Timetable_Click(object sender, EventArgs e)
        {

        }

        private void ListOfFeeders_Click(object sender, EventArgs e)
        {
            f.Show();
        }

        private void RevieLogs_Click(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
