using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Models.Entity;

namespace Models.Service
{
    public class SimulationServise : ISimulationServise
    {
        private int TimeBoost = 1;
        private int SimStop;
        public Feeder feeder;
        public CatService cat1;
        public void StartSim()
        {
            SimStop = 0;

            feeder = new Feeder
            {
                MountOfFood = 100
            };
            cat1 = new CatService("Barsik");
            TimeNow = DateTime.Now;

            Task ThreadSim = new Task(SimEnvironment);
            ThreadSim.Start();
        }
        public void StopSim()
        {
            SimStop = 1;
        }
        private void SimEnvironment()
        {

            feeder.FeedingSchedule.FeedTime.Add(DateTime.Now.AddHours(1));
            while (SimStop == 0)
            {
                if (TimeNow > cat1.ThisCat.TimeToEat)
                {
                    cat1.Eat(feeder);
                    cat1.ThisCat.TimeToEat = cat1.ThisCat.TimeToEat.AddHours(12);
                }
                foreach (DateTime FeedTime in feeder.FeedingSchedule.FeedTime)
                    if (TimeNow.Day == FeedTime.Day && TimeNow.Hour == FeedTime.Hour && TimeNow.Minute == FeedTime.Minute)
                    {
                        feeder.Feed(feeder.FeedingSchedule.portion);
                        feeder.FeedingSchedule.FeedTime.Add(FeedTime.AddHours(11));
                        break;
                    }
                Thread.Sleep(1000 / TimeBoost);
                TimeNow = TimeNow.AddMinutes(1);
            }
        }
        public void TimeBoostUp()
        {
            if (TimeBoost < 1000) TimeBoost *= 10;
        }
        public void TimeBoostDown()
        {
            if (TimeBoost > 1) TimeBoost /= 10;
        }
        public DateTime TimeNow;
    }
}
