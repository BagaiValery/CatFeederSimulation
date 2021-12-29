using Models.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface IShceduleService
    {
        /// <summary>
        /// Cоставление расписания.
        /// </summary>
        void AddSchedule(Schedule obj);
        /// <summary>
        /// Выбор расписания.
        /// </summary>
        void ChooseSchedule(Schedule obj);

        /// <summary>
        /// Экспорт расписания.
        /// </summary>
        /*FileInfo*/ void ExportSchedule(Schedule obj, FileInfo textFile);

        /// <summary>
        /// Импорт расписания.
        /// </summary>
        Schedule ImportSchedule(FileInfo f);

        void SetSchedule(Feeder feeder, Schedule schedule);
    }
}
