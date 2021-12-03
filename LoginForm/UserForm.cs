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
        ManualHandlingForm mhf = new ManualHandlingForm();

        TimetableForm tm = new TimetableForm();

        Feeders f = new Feeders();

        LogsForm lf = new LogsForm();  
        public UserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mhf.Show();
        }

        private void Timetable_Click(object sender, EventArgs e)
        {
            tm.Show();
        }

        private void ListOfFeeders_Click(object sender, EventArgs e)
        {
            f.Show();
        }

        private void RevieLogs_Click(object sender, EventArgs e)
        {
            lf.Show();
        }
    }
}
