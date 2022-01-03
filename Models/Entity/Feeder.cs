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

        public string FeederName { get; set; }

        public int MountOfFood { get; set; }

        public int FoodInBowl { get; private set; }

        public Feeder()
        {
            FeedingSchedule = new Schedule();
        }

        public bool IsThisFeederEmpty()
        {
            bool Empty = false;
            if (MountOfFood == 0)
                Empty = true;
            if (MountOfFood < 0)
                throw new Exception("Что-то пошло не так: в кoрмушке меньше корма, чем null");
            return Empty;
        }
        public bool Feed(int portion)
        {
            if (!IsThisFeederEmpty())
            {
                MountOfFood -= portion;
                FoodInBowl += portion;
                return IsThisFeederEmpty();
            }
            else return false;
        }
        public bool EmptyBowl()
        {
            if (FoodInBowl > 0)
            {
                FoodInBowl = 0;
                return true;
            }
            else return false;
        }

        public int MakeFull()
        {
            MountOfFood = 500;
            return MountOfFood;
        }

        public Schedule FeedingSchedule { get; set; }

        public string FeederUser { get; set; }

        public int maxFood { get; set; }

    }
}
