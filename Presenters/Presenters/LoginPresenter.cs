using Presenters.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.Presenters
{
    class LoginPresenter
    {
        IUser LoginView;

        public LoginPresenter(IUser view)
        {
            LoginView = view;
        }

        public void FindUser()
        {
            UserDb user = new UserDb();
        }

        public void MessFind()
        {
            User user = new User();
            user.Login = LoginView.LoginTxt;
            user.Pass = LoginView.PassTxt;

            LoginView.MessFind = user.MessFind().ToString();
        }

        public void MessAdd()
        {
            User user = new User();
            user.Login = LoginView.LoginTxt;
            user.Pass = LoginView.PassTxt;

            LoginView.MessFind = user.MessAdd().ToString();
        }
    }
}
