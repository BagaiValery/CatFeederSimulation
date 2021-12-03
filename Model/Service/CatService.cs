using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enity;

namespace Model.Service
{
    class CatService : ICatService
    {
        public Cat ThisCat = new Cat();
        public CatService(string CatName)
        {
            ThisCat.Name = CatName;
            DateTime FeedTime = DateTime.Now;
            FeedTime.AddHours(2);
            ThisCat.TimeToEat = new DataTime(FeedTime);
        }
        public void Eat(Feeder feeder)
        {
            if (feeder.IsThisFeederEmpty())
                Meow(/*Feeder*/);
            else feeder.EmptyBowl;
        }
        public void Meow(/*Feeder*/)
        {
            //Meow
        }
    }
}
