using Presenter.Presenters;
using Presenter.View;
using System;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class RegistrateForm : Form, IUser
    {
        public RegistrateForm()
        {
            InitializeComponent();
        }

        public string LoginTxt
        { 
            get 
            { return NameBox.Text; }
            set 
            {NameBox.Text=value; } 
        }
        public string PassTxt 
        { 
            get 
            { return PasswordBox.Text; }
            set 
            {PasswordBox.Text=value; } 
        }
        public int Mess { get; set ; }
        //int IUser.Mess { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPresenter presenter = new LoginPresenter(this);

            if (presenter.MessAddUser() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Возникли проблемы с созданием");
        }

    }
}
