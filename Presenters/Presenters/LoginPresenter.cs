using Model.Enity;
using LoginForm.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.Presenters
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

        public void MessFind()
        {
            User user = new User(LoginView.LoginTxt,LoginView.PassTxt);

            LoginView.Mess = user.MessFind().ToString();
        }

        public void MessAdd()
        {
            User user = new User(LoginView.LoginTxt,LoginView.PassTxt);
            LoginView.Mess = user.MessAdd().ToString();
        }
    }
}
