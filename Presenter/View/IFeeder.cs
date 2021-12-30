using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.View
{
    public interface IFeeder
    {
        string feederNameTxt {get; set;}
        string feederUserTxt { get; set; }
        string maxFoodTxt { get; set; }
        string portionTxt { get; set; }
        int Mess { get; set; }
    }
}
