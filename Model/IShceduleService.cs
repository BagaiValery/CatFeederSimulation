using Model.Enity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    interface IShceduleService
    {
        /// <summary>
        /// Cоставление расписания.
        /// </summary>
        public void AddSchedule(Schedule obj);
        /// <summary>
        /// Выбор расписания.
        /// </summary>
        public void ChooseSchedule(Schedule obj);

        /// <summary>
        /// Экспорт расписания.
        /// </summary>
        public /*FileInfo*/ void ExportSchedule(Schedule obj, FileInfo textFile);

        /// <summary>
        /// Импорт расписания.
        /// </summary>
        public Schedule ImportSchedule(FileInfo f);

        public void SetSchedule(Feeder feeder, Schedule schedule);
    }
}
