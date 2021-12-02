using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    class CatService
    {
        public Cat(string CatName)
        {
            Cat ThisCat = new Cat {Name = CatName};
        }
        public void Eat(VirtFeederService Feeder1)
        {
            if (Feeder1.EmptyBowl() == 1) Meow(/*Feeder*/);
        }
        public void Meow(/*Feeder*/)
        {
            //Meow
        }
        public bool IsThereFood(VirtFeederService Feeder1)
        {
            if (Feeder1.GetBowl() == 0)
                return false;
            else
                return true;
        }
    }
}
