using LoginForm.View;
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
        public string Mess { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        private void button1_Click(object sender, EventArgs e)
        {
            LoginPresenter presenter = new LoginPresenter(this);

            if (presenter.MessAdd() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Возникли проблемы с созданием");
        }
    }
}
