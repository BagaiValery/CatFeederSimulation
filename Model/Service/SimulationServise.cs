using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Model.Entity;

namespace Model.Service
{
    class SimulationServise
    {
        private static int TimeBoost = 1;
        private static int SimStop;
        //Feeder Database
        public void StartSim()
        {
            SimStop = 0;
            Cat Cat1 = new Cat("Barsik");
            //Feeder Database Access
            Thread ThreadSim = new Thread(new ThreadStart(SimEnvironment));
            ThreadSim.Start();
        }
        public void StopSim()
        {
            SimStop = 1;
        }
        public static void SimEnvironment()
        {
            while (SimStop == 0)
            {
                if (TimeNow.Equals(Cat1.GetTimeToEat()))
                {
                    if (Cat1.IsThereFood(Feeder1))
                        Cat1.Eat(Feeder1);
                    else
                        Cat1.Meow(/*RealFeeder1*/);
                }
                if (TimeNow.Equals(Feeder1.GetSchedule()))
                {
                    Feeder1.FullBowl();
                }
                System.Threading.Thread.Sleep(1000 / TimeBoost);
                TimeNow.PlusMin(1);
            }
        }
        public int TimeBoostSet(int times)
        {
            if (times < 1 || times > 1000)
                return 1;
            else TimeBoost = times;
            return 0;
        }
        private static Time TimeNow = new Time();
    }
}
