using Models.Entity;
using Presenter.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class LoginPresenter
    {
        IUser LoginView;

    public LoginPresenter(IUser view)
    {
        LoginView = view;
    }

    public int MessFindUser()
    {
        DB user = new DB();
            //LoginView.LoginTxt, LoginView.PassTxt

           return LoginView.Mess = user.Find("users", "login", "password", LoginView.LoginTxt, LoginView.PassTxt);
    }

    public int MessAddUser()
    {
            DB user = new DB();
            return LoginView.Mess = user.Add("users", "login", "password", LoginView.LoginTxt, LoginView.PassTxt);
    }

    }
}
