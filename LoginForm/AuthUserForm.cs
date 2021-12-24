
using LoginForm.View;
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
        public string Mess { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void EnterAuthbutton_Click(object sender, EventArgs e)
        {
            Presenters.Presenters.LoginPresenter presenter = new LoginPresenter(this);
            
            if(presenter.MessFind() > 0)
                MessageBox.Show("Пользователь найден");
            else
                MessageBox.Show("Пользователя не существует");
        }
    }
}
