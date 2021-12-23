using MySql.Data.MySqlClient;
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
    public partial class AuthUserForm : Form
    {
        public AuthUserForm()
        {
            InitializeComponent();
        }

        private void EnterAuthbutton_Click(object sender, EventArgs e)
        {
            String LoginUser = NameBox.Text;
            String PassUser = PasswordBox.Text;
            UserDB userdb = new UserDB();


            if (FindUser(LoginUser, PassUser) > 0)
                MessageBox.Show("All is ok");
            else
                MessageBox.Show("User is lost or not be here");
        }
    }
}
