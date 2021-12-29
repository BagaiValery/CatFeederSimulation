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

    public void FindUser()
    {
        UserDB user = new UserDB();
    }

    public int MessFind()
    {
        User user = new User(LoginView.LoginTxt, LoginView.PassTxt);

           return LoginView.Mess = user.MessFind();
    }

    public int MessAdd()
    {
        User user = new User(LoginView.LoginTxt, LoginView.PassTxt);
        return LoginView.Mess = user.MessAdd();
    }
    }
}
