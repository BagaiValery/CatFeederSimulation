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
        public int portion { get; set; }
        /// <summary>
        /// Массив времени кормёжки по расписанию
        /// </summary>
        public List<DateTime> FeedTime { get; set; }

        public void AddToTimeList(DateTime feedtime)
        {
            DateTime nowDateTime = DateTime.Now;
            DateTime TheLatestPossible = nowDateTime.AddDays(2);
            if((feedtime > DateTime.Now) && (feedtime.Day <= TheLatestPossible.Day))
            this.FeedTime.Add(feedtime);
        }

        public Schedule(DateTime feedtime, int mountOffeed)
        {
            DateTime nowDateTime = DateTime.Now;
            DateTime TheLatestPossible = nowDateTime.AddDays(2);
            if ((feedtime > DateTime.Now) && (feedtime.Day <= TheLatestPossible.Day))
                this.FeedTime.Add(feedtime);
            this.portion = mountOffeed;
        }

        public Schedule()
        {
            this.portion = 0;
            this.FeedTime.Clear();
        }
        
    }
}
