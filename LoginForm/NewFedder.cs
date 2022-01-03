﻿using Presenter.Presenters;
using Presenter.View;
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
    public partial class NewFedder : Form, IFeeder
    {
        public string feederNameTxt { get { return NewFeederName.Text; } set => NewFeederName.Text=value; }
   //     public string feederUserTxt { get { return userList.SelectedItem.ToString(); } 
        public string feederUserTxt { get { return userList.Text; } 

            set {
                userList.Items.Add(value); 
            } }
        public string maxFoodTxt { get ; set ; }
        public string portionTxt { get ; set ; }
        public int Mess { get; set ; }

        public NewFedder()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewFedder_Load(object sender, EventArgs e)
        {

        }

        private void creat_Click(object sender, EventArgs e)
        {
            FeederPresenter users = new FeederPresenter(this);
            if (users.MessAddFeederForUser() == 1)
                MessageBox.Show("Кормушка была создана");
            else
                    MessageBox.Show("Возникли проблемы с созданием");
            

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
       //     Authorization auth = new Authorization();
       //     auth.Show();
        }

        private void userList_DropDown(object sender, EventArgs e)
        {
            FeederPresenter users = new FeederPresenter(this);

            userList.DataSource = users.Users();
            userList.DisplayMember = "login";
            //userList.ValueMember = "id";

        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
