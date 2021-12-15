using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Model.Enity;

namespace Model.Service
{
    class SimulationServise : ISimulationServise
    {
        private static int TimeBoost = 1;
        private static int SimStop;
        //Feeder Database
        public void StartSim()
        {
            SimStop = 0;
            CatService cat = new CatService("Barsik");
            //Feeder Database Access
            Thread ThreadSim = new Thread(new ThreadStart(SimEnvironment));
            ThreadSim.Start();
        }
        public void StopSim()
        {
            SimStop = 1;

        }
        private static void SimEnvironment()
        {
            CatService cat1 = new CatService("Barsik");
            while (SimStop == 0)
            {
                if (TimeNow.Equals(cat1.ThisCat.TimeToEat))
                {
                    Feeder feeder1 = new Feeder(); /*for (Through all feeders)*/
                        cat1.Eat(feeder1);
                        cat1.ThisCat.TimeToEat.AddHours(12);
                }
                Feeder feeder = new Feeder();/*for(Through all feeders)*/
                    if (TimeNow.Equals(feeder.FeedingSchedule))
                    {
                        feeder.Feed(feeder.FeedingSchedule.portion);
                    }
                System.Threading.Thread.Sleep(1000 / TimeBoost);
                TimeNow.AddMinutes(1);
            }
        }
        public void TimeBoostSet(int times)
        {
            if (times < 1 || times > 1000)
                throw new Exception("Помедленнее!");
            else TimeBoost = times;
        }
        private static DateTime TimeNow = new DateTime();
    }
}
