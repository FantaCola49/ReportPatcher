namespace ReportPatcher.BusinessLogic.Interfaces
{
    /// <summary>
    /// Интерфейс для работы с классом изменения файлов
    /// </summary>
    internal interface IReportChanger
    {
        void ModifyDocument(string ModifiedReportPath);
        void ModifyDocumentsInFolder(string ReportFolderPath);
    }
}
