using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.View
{
    public interface ISimulation
    {
        string FeederText { get; set; }
        string BowlText { get; set; }
        string MeowText { get; set; }
        string TimeText { get; set; }
        string FeedingText { get; set; }
        string PortionText { get; set; }
    }
}
