using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enity
{
    public class Feeder
    {
        public int portion { get; set; }
        public Schedule FeedingSchedule { get; set; }
        public string FeederName { get; set; }

        public Schedule FeederSchedule { get; set; }

        public int MountOfFood { get; set; }

        public int FoodInBowl { get; private set; }

        public bool IsThisFeederEmpty()
        {
            bool Empty=false;
            if (MountOfFood == 0)
                Empty = true;
            if (MountOfFood < 0)
                throw new Exception("Что-то пошло не так: в кармушке меньше корма, чем null");
            return Empty;
        }
        public bool Feed(int portion)
        {
            MountOfFood -= portion;
            FoodInBowl += portion;
            return IsThisFeederEmpty();
        }
        public void EmptyBowl()
        {
            IsThisFeederEmpty(); 
            if (FoodInBowl > 0) FoodInBowl = 0;
            else throw new Exception("Что-то пошло не так: в миске нет корма");
        }

        public int MakeFull (int food)
        {
            MountOfFood = food;
            return MountOfFood;
        }
    }
}
