
using Presenter.View;
using Presenter.Presenters;
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
    public partial class AuthUserForm : Form, IUser
    {
        public AuthUserForm()
        {
            InitializeComponent();
        }

        public string LoginTxt {
            get
            { return NameBox.Text; }
            set
            { NameBox.Text = value; }
        }
        public string PassTxt
        {
            get
            { return PasswordBox.Text; }
            set
            { PasswordBox.Text = value; }
        }
        public int Mess { get ; set ; }

        private void EnterAuthbutton_Click(object sender, EventArgs e)
        {
            LoginPresenter presenter = new LoginPresenter(this);

            if (presenter.MessFindUser() > 0)
                MessageBox.Show("Пользователь найден");
            else
                MessageBox.Show("Пользователя не существует");
        }

        private void back1_Click(object sender, EventArgs e)
        {
            this.Hide();
          //  Authorization auth = new Authorization();
          //  auth.Show();
        }
    }
}
