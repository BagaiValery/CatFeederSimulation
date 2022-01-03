using Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Service
{
    public class CatService : ICatService
    {
        public Cat ThisCat = new Cat();
        public bool Meow { get; private set; }
        public CatService(string CatName)
        {
            ThisCat.Name = CatName;
            ThisCat.TimeToEat = new DateTime();
            ThisCat.TimeToEat = DateTime.Today;
            if (DateTime.Now.Hour < 12 )
                ThisCat.TimeToEat = ThisCat.TimeToEat.AddHours(12);
            else ThisCat.TimeToEat = ThisCat.TimeToEat.AddDays(1);

        }
        public void Eat(Feeder feeder)
        {
            if (feeder.EmptyBowl()) Meow = false;
            else Meow = true;
        }
    }
}
