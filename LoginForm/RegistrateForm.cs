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
    public partial class RegistrateForm : Form
    {
        public RegistrateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = NameBox.Text;
            string Password = PasswordBox.Text;
            labelr.Text = Name + " " + Password;
        }
    }
}
