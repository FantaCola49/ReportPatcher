using ReportPatcher.BusinessLogic.Interfaces;
using System;
using System.IO;

namespace ReportPatcher.BusinessLogic.Calculations
{
    /// <summary>
    /// Класс работы с мета-данными файлов
    /// </summary>
    public class ReportsMetaData : IReportsMetaData
    {
        /// <summary>
        /// Получить дату изменения файла до обновления
        /// </summary>
        /// <param name="FilePath">Путь к файлу</param>
        /// <returns></returns>
        public DateTime GetFileDataBeforeUpdate(string FilePath)
        {
            return File.GetLastWriteTime(FilePath);
        }

        /// <summary>
        /// Установить дату изменения файла как до обновления
        /// </summary>
        /// <param name="FilePath">Путь к файлу</param>
        /// <param name="DateBeforeUpd">Время до обновы</param>
        public void SetFileDataAsBeforeUpdate(string FilePath, DateTime DateBeforeUpd)
        {
            File.SetLastWriteTime(FilePath, DateBeforeUpd);
        }

        /// <summary>
        /// Вернёт количество файлов в папке
        /// </summary>
        /// <param name="folderPath">Путь к папке</param>
        /// <returns></returns>
        public int CountReportsInFolder(string folderPath)
        {
            return Directory.GetFiles(folderPath).Length;
        }
    }
}
