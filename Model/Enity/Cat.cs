using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Service;

namespace Model.Entity
{
    class Cat
    {
        private int Appetite;
        private string Name;
        public Cat(string CatName)
        {
            Name = CatName;
            TimeToEat.timeset(0, 0);
            Appetite = 100;
        }
        public void SetTimeToEat(int hour, int minute)
        {
            TimeToEat.timeset(hour, minute);
        }
        public Time GetTimeToEat()
        {
            return TimeToEat;
        }
        private Time TimeToEat = new Time();
        public void Eat(VirtFeederService Feeder1)
        {
            if (Feeder1.SetBowl(Appetite) == 1) Meow(/*RealFeeder*/);
        }
        public void Meow(/*RealFeeder*/)
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
