using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportPatcher.BusinessLogic.WorkWithMainWindow
{
    /// <summary>
    /// Класс, заполняющий поля данных об организации для Изварино
    /// </summary>
    /// <remarks>Тест. Потом отключить!</remarks>
    internal class ForIzvarino
    {
        MainWindow window;

        public readonly string ShortName = "ООО «Изварино Фарма»";
        public readonly string FullName = "Общество с ограниченной ответственностью  \"Изварино Фарма\"";
        public readonly string FSRAR_ID = "030000083685";
        public readonly string Inn = "5003022562";
        public readonly string Kpp = "775101001";
        public readonly string Country = "643";
        public readonly string RegionCode = "77";
        public readonly string Description = "108817, г. Москва, (п. Внуковское),  Внуковское шоссе, 5-й км., домовл. 1, стр. 1.";


        private void AdjustIzvarinoData()
        {
            window = new MainWindow();
            window.ShortNameTB.Text = ShortName;
            window.FullNameTB.Text = FullName;
            window.ClientRegIdTB.Text = FSRAR_ID;
            
        }
    }
}
