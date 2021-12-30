using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Service
{
    class SimulationServise : ISimulationServise
    {
        public static int TimeBoost { get; set; }
        private static int SimStop;

         /*       public void StartSim()
                {
                    SimStop = 0;
                    CatService cat = new CatService("Barsik");
                    Task ThreadSim = new Task(new ThreadStart(SimEnvironment));
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
        <<<<<<< HEAD
                            Feeder feeder1 = new Feeder(); 
        =======
                            Feeder feeder1 = new Feeder();
        >>>>>>> c2734142e0200a69946967240fc985ec632ae35b
                                cat1.Eat(feeder1);
                                cat1.ThisCat.TimeToEat.AddHours(12);
                        }
                        Feeder feeder = new Feeder();
                            if (TimeNow.Equals(feeder.FeedingSchedule))
                            {
                                feeder.Feed(feeder.FeedingSchedule.portion);
                            }
                        System.Threading.Thread.Sleep(1000 / TimeBoost);
                        TimeNow.AddMinutes(1);
                    }
                }
        */
        public void TimeBoostSet(int times)
        {
            if (times < 1 || times > 1000)
                throw new Exception("Помедленнее!");
            else TimeBoost = times;
        }

        void ISimulationServise.StartSim()
        {
            throw new NotImplementedException();
        }

        void ISimulationServise.StopSim()
        {
            throw new NotImplementedException();
        }

        private static DateTime TimeNow = new DateTime();
    }
}
