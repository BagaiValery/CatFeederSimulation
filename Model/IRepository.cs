using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IRepository<T> where T: class
    {
        /// <summary>
        /// Добавление данных в репозиторий.
        /// </summary>
        /// <param name="obj">Добавляется объект нужного класса.</param>
        /// <returns></returns>
        int AddRepository(T obj);
        /// <summary>
        /// Изменение данных в репозитории.
        /// </summary>
        /// <param name="obj">Изменяется объект нужного класса.</param>
        void UpdateRepository(T obj);
        /// <summary>
        /// Удаление репозитория.
        /// </summary>
        /// <param name="obj">Репозиторий определённого класса.</param>
        void RemoveRepository(T obj);
        /// <summary>
        /// Сохранение репозитория.
        /// </summary>
        void SaveRepository();
    }
}
