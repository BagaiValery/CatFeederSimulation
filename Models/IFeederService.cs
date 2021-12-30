using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IFeederService
    {
        bool IsThisFeederEmpty();
        bool Feed(int portion);
        void EmptyBowl();
        int MakeFull();
    }
}
