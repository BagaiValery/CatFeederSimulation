using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    interface ISimulationServise
    {
        public void StartSim();
        public void StopSim();
        public void TimeBoostSet(int times);
    }
}
