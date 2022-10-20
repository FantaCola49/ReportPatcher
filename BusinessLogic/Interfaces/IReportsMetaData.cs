using System;

namespace ReportPatcher.BusinessLogic.Interfaces
{
    /// <summary>
    /// Интерфейс для класса работы с мета-данными файлов
    /// </summary>
    public interface IReportsMetaData
    {
        void SetFileDataAsBeforeUpdate(string FilePath, DateTime DateBeforeUpd);
        DateTime GetFileDataBeforeUpdate(string pathToFile);
        int CountReportsInFolder(string folderPath);
    }
}
