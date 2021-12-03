using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entity;

namespace Model.Service
{
    class CatService : ICatService
    {
        public Cat(string CatName)
        {
            Cat ThisCat = new Cat {Name = CatName};
        }
        public void Eat(/*Feeder*/)
        {
            if (Feeder1.EmptyBowl() == 1) Meow(/*Feeder*/);
        }
        public void Meow(/*Feeder*/)
        {
            //Meow
        }
    }
}
