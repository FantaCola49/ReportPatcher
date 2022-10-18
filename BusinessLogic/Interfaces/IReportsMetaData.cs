using System;

namespace ReportPatcher.BusinessLogic.Interfaces
{
    public interface IReportsMetaData
    {
        public DateTime SetFileDataAsBeforeUpdate();
        public int CountReportsInFilder(string folderPath);
    }
}
