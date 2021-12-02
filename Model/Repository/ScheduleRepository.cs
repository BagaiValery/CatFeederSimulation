using Model.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public class ScheduleRepository : IRepository<Schedule>
    {
        public List<Schedule> ScheduleList = new List<Schedule>();


        public int AddRepository(Schedule obj)
        {
            this.ScheduleList.Add(obj);
        }

        public void RemoveRepository(T obj)
        {
            this.ScheduleList.Clear(obj);
        }

        public void SaveRepository()
        {
            throw new NotImplementedException();
        }

        public void UpdateRepository(Schedule obj)
        {
            throw new NotImplementedException();
        }
    }
}
