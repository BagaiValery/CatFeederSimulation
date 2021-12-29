using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.View
{
    public interface IUser
    {
        string LoginTxt { get; set; }
        string PassTxt { get; set; }
        int Mess { get; set; }
    }
}
