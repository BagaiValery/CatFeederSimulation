using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enity
{
    public class Schedule
    {
        /// <summary>
        /// Имя кормушки, в чьём расписании находимся.
        /// </summary>
        public string FeederName { get { return FeederName; } private set {; } }
        /// <summary>
        /// Количество корма по расписанию
        /// </summary>
        public int MountOfFeed { get; set; }
        /// <summary>
        /// Массив времени кормёжки по расписанию
        /// </summary>
        public List<DateTime> FeedTime { get; set; }

        public void AddToTimeList(DateTime feedtime)
        {
            this.FeedTime.Add(feedtime);

        }

        public Schedule(DateTime timeTofeed, int mountOffeed)
        {
            this.FeedTime.Add(timeTofeed);
            this.MountOfFeed = mountOffeed;
        }

        public Schedule()
        {
            this.MountOfFeed = 0;
            this.FeedTime.Clear();
        }
    }
}
