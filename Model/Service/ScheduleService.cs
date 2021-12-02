using Model.Enity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    class ScheduleService : IShceduleService
    {
        public Schedule schedule { get; }
        public void AddSchedule(Schedule obj)
        {
            string FeederName = obj.FeederName;
            int NumFeed = obj.MountOfFeed;
            List<DateTime> TimeFeed = obj.FeedTime;
        }

        public void ChooseSchedule(Schedule obj)
        {
            if (obj != null)
            {
                Console.WriteLine("Everything is correct");
            }
            else Console.WriteLine("Something is wrong? maby your file is empty!");

        }

        public /*FileInfo*/ void ExportSchedule(Schedule obj, FileInfo textFile)
        {
            
            /*StreamWriter textWriter = File.CreateText();
            textWriter.WriteLine(obj);
            textWriter.Close();*/
        }

        public Schedule ImportSchedule(FileInfo f)
        {
            throw new NotImplementedException();
        }
    }
}
