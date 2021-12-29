using Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Service
{
    class CatService : ICatService
    {
        public Cat ThisCat = new Cat();
        public CatService(string CatName)
        {
            ThisCat.Name = CatName;
            ThisCat.TimeToEat = new DateTime();
            ThisCat.TimeToEat = DateTime.Now;
            ThisCat.TimeToEat.AddHours(2);

        }
        public void Eat(Feeder feeder)
        {
            if (feeder.IsThisFeederEmpty())
                Meow(/*Feeder*/);
            else feeder.EmptyBowl();
        }
        public void Meow(/*Feeder*/)
        {
            //Meow
        }
    }
}
