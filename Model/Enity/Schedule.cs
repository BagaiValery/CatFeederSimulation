using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enity
{
    public class Schedule
    {

        private string NameOfFedder;
        /// <summary>
        /// Количество корма по расписанию
        /// </summary>
        private int MountOfFeed { get; set; }
        /// <summary>
        /// Массив времени кормёжки по расписанию
        /// </summary>
        private List<DateTime> TimeToFeed { get; set; }

        public Schedule(DateTime timeTofeed, int mountOffeed)
        {
            this.TimeToFeed.Add(timeTofeed);
            this.MountOfFeed = mountOffeed;
        }

        public Schedule()
        {
            this.MountOfFeed = 0;
            this.TimeToFeed.Clear();
        }
    }
}
