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

            DB db = new DB();
            DataTable Usertable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandChooseUser = new MySqlCommand("SELECT * FROM 'users' WHERE 'login' = @uL AND 'pass' = @uP", db.getConnection());
            commandChooseUser.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginUser;
            commandChooseUser.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassUser;

            adapter.SelectCommand = commandChooseUser;
            adapter.Fill(Usertable);

            if (Usertable.Rows.Count > 0)
                MessageBox.Show("All is ok");
            else
                MessageBox.Show("User is lost or not be here");
        }
    }
}
