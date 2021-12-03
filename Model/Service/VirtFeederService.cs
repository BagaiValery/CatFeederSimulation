using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entity;

namespace Model.Service
{
    class VirtFeederService : IFeederConnector
    {
        private int Tub = 0;
        private int Bowl;
        public void FeedNow(int amount)
        {
            if (Tub >= count)
            {
                Bowl += amount;
                Tub -= count;
            }
            else
                /*Send signal*/;
            
            TakeFromTub(amount);
        }
        public int EmptyBowl()
        {
            if (Bowl > 0)
            {
                Bowl = 0;
                return 0;
            }
            else return 1;  
        }
        public Schedule MySchedule { get; set; }
    }
}
