using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    class VirtFeederService : IFeederConnector
    {
        private static int Tub = 0;
        public static void TakeFromTub(int count)
        {
            Tub -= count;
        }

        private static int Bowl = 0;
        public void FeedNow(int amount)
        {
            Bowl += amount;
            TakeFromTub(amount);
        }
        public void SetSchedule(/*Schedule link*/)
        {

        }
        public void GetSchedule()
        {

        }
    }
}
