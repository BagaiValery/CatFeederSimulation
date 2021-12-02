using Model.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository
{
    public class ScheduleRepository : IRepository<Schedule>
    {
        public List<Schedule> ScheduleList = new List<Schedule>();

        public void AddRepository(Schedule obj)
        {
            this.ScheduleList.Add(obj);
        }

        public void SaveRepository()
        {
            throw new NotImplementedException();
        }

        public void UpdateRepository(Schedule obj)
        {
            if(Schedule)
            this.ScheduleList
        }

        void IRepository<Schedule>.RemoveRepository(Schedule obj)
        {
            this.ScheduleList.Clear();
        }
    }
}
