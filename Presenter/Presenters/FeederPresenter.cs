using Models.Entity;
using Presenter.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class FeederPresenter
    {
        IFeeder FeederView;

        public FeederPresenter(IFeeder view)
        {
            FeederView = view;
        }

        public int MessFind()
        {
            DB user = new DB();
            //LoginView.LoginTxt, LoginView.PassTxt
            return FeederView.Mess = user.Find("feeders", "feederName", "user", FeederView.feederNameTxt, FeederView.feederUserTxt);
        }

        public int MessAddForUser()
        {
            DB user = new DB();
            return FeederView.Mess = user.Add("feeders", "feederName", "user", FeederView.feederNameTxt, FeederView.feederUserTxt);
        }

        public int MessAddInfo()
        {
            DB user = new DB();
            return FeederView.Mess = user.Add("feeders", "maxFood", "portion", FeederView.maxFoodTxt, FeederView.portionTxt);
        }

        public int MessFindForUser()
        {
            DB user = new DB();
            //LoginView.LoginTxt, LoginView.PassTxt
            return FeederView.Mess = user.Find("feeders", "user", FeederView.feederUserTxt);
        }
    }
}
