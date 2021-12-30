using Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Service
{
    public class FeederService : IFeederService
    {
        Feeder feeder = new Feeder();
        public bool IsThisFeederEmpty()
        {
            bool Empty = false;
            if (feeder.maxFood == 0)
                Empty = true;
            if (feeder.maxFood < 0)
                throw new Exception("Что-то пошло не так: в кармушке меньше корма, чем null");
            return Empty;
        }
        public bool Feed(int portion)
        {
            //    MountOfFood -= portion;
            //    FoodInBowl += portion;
            return IsThisFeederEmpty();
        }
        public void EmptyBowl()
        {
            //    if (FoodInBowl > 0) FoodInBowl = 0;
            //    else throw new Exception("Что-то пошло не так: в миске нет корма");
        }

        public int MakeFull()
        {
            maxFood = 500;
            return maxFood;
        }
    }
}
