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
        ILoginView LoginView;

        public LoginPresenter(ILoginView view)
        {
            LoginView = view;
        }
    }
}
