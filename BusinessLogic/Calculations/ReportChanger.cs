using ReportPatcher.BusinessLogic.Interfaces;
using System;
using System.IO;
using System.Xml;

namespace ReportPatcher.BusinessLogic.Calculations
{
    public class ReportChanger : IReportChanger
    {
        DataDTO dto;

        /// <summary>
        /// Cto-r
        /// </summary>
        /// <param name="FilledDto"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ReportChanger(DataDTO FilledDto)
        {
            if (FilledDto == null) throw new ArgumentNullException(nameof(dto));
            this.dto = FilledDto;
        }

        /// <summary>
        /// Модифицировать все документы в указанной папке
        /// </summary>
        /// <param name="ReportFolderPath">Путь к файлам</param>
        public void ModifyDocumentsInFolder(string ReportFolderPath)
        {
            ReportsMetaData md = new ReportsMetaData();
            int reportNumb = md.CountReportsInFolder(ReportFolderPath);

            for(int i = 0; i < reportNumb; i++)
            {
                string file = Directory.GetFiles(ReportFolderPath)[i];
                ModifyDocument(file);
            }
        }

        /// <summary>
        /// Алгоритм модификации репорта
        /// </summary>
        /// <param name="ModifiedReportPath"></param>
        /// <remarks>Модификация файла НЕ ОТРАЗИТСЯ на времени его изменения</remarks>
        public void ModifyDocument(string ModifiedReportPath)
        {
            XmlDocument doc = new XmlDocument();
            ReportsMetaData md = new ReportsMetaData();
            DateTime beforeUpd = md.GetFileDataBeforeUpdate(ModifiedReportPath);
            doc.Load(ModifiedReportPath);
            doc.FirstChild.NextSibling.FirstChild.FirstChild.InnerText = dto.ClientRegId;
            var Producer = doc.FirstChild.NextSibling.FirstChild.NextSibling.FirstChild.FirstChild.NextSibling.FirstChild.ChildNodes;
            Producer[0].InnerText = dto.ClientRegId; // ClientRegId
            Producer[1].InnerText = dto.FullName; //FullName
            Producer[2].InnerText = dto.ShortName; //ShortName
            Producer[3].InnerText = dto.INN; //INN
            Producer[4].InnerText = dto.KPP; // KPP
            Producer[5].FirstChild.InnerText = dto.Country; //Country (Russia as default)
            Producer[5].FirstChild.NextSibling.InnerText = dto.RegionCode; //RegionCode
            Producer[5].FirstChild.NextSibling.NextSibling.InnerText = dto.JuridicalAddress; //Description
            doc.Save(ModifiedReportPath);
            md.SetFileDataAsBeforeUpdate(ModifiedReportPath, beforeUpd);
        }
    }
}
