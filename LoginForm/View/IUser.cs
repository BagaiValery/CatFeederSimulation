using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.View
{
    public interface IUser
    {
        string LoginTxt { get; set; }
        string PassTxt { get; set; }
        string Mess { get; set; }
    }
}
