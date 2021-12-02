using Model.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    interface IFeederConnector
    {
        void FeedNow(int amount);
        public Schedule MySchedule { get; set; }
    }
}
