using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity
{
    public class Feeder
    {
        public int portion { get; set; }
        //public Schedule FeedingSchedule { get; set; }
        public string FeederName { get; set; }

        public string FeederUser { get; set; }

        public int maxFood { get; set; }

        //public int FoodInBowl { get; private set; }

 

        //public int MessFind()
        //{
        //    DB userdb = new DB();
        //    return userdb.Find("feeders", "feederName", "user", FeederName, FeederUser);
        //}

        //public int MessAddForUser()
        //{
        //    DB userdb = new DB();
        //    return userdb.Add("feeders", "feederName", "user", FeederName, FeederUser);
        //}

        //public int MessAddDataForFeeder()
        //{
        //    DB userdb = new DB();
        //    return userdb.Add("feeders", "maxFood", "portion", maxFood.ToString(), portion.ToString());
        //}
    }
}
