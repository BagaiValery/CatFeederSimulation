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

        public int MessFindFeeder()
        {
            DB user = new DB();
            //LoginView.LoginTxt, LoginView.PassTxt
            return FeederView.Mess = user.Find("feeders", "feederName", "user", FeederView.feederNameTxt, FeederView.feederUserTxt);
        }

        public int MessAddFeederForUser()
        {
            DB feeder = new DB();
            return FeederView.Mess = feeder.Add("feeders", "feederName", "user", FeederView.feederNameTxt, FeederView.feederUserTxt);
        }

        public int MessAddInfoFeeder()
        {
            DB feeder = new DB();
            return FeederView.Mess = feeder.Add("feeders", "maxFood", "portion", FeederView.maxFoodTxt, FeederView.portionTxt);
        }

        public int MessFindFeederForUser()
        {
            DB feeder = new DB();
            //LoginView.LoginTxt, LoginView.PassTxt
            return FeederView.Mess = feeder.Find("feeders", "user", FeederView.feederUserTxt);
        }

        public int MessCount()
        {
            DB feeder = new DB();
            int count = feeder.Find("users", "login");
            return count;
        }

        public string[] Users()
        {
            DB feeder = new DB();
            string[] users = new string[MessCount()];
            users = feeder.GetAll("users", "login");
            return users;
        }
    }
}
