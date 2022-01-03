using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface ISimulationServise
    {
        void StartSim();
        void StopSim();
        void TimeBoostUp();
        void TimeBoostDown();
    }
}
