using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.WindowsAPICodePack.Dialogs;
using ReportPatcher.BusinessLogic.Calculations;
using ReportPatcher.BusinessLogic.ComboBoxData;
using ReportPatcher.BusinessLogic.Entities;

namespace ReportPatcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Regex digitalFilter = new Regex(@"\d");
        private readonly string ModifiedReportPath = $@"{Directory.GetCurrentDirectory()}\Resources\Data\DailyReportModified.xml";
        private readonly string StandartReportPath = @$"{Directory.GetCurrentDirectory()}\Resources\Data\DailyReportStandart.xml";

        public MainWindow()
        {
            InitializeComponent();
            // Подгружаем стандартный отчёт
            TestReportTB.Text = File.ReadAllText(StandartReportPath);
            // Подгружаем список стран (Только РФ)
            FillCountriesComboBox();
            // Подгружаем список регионов
            FillRegionsComboBox();
        }



        /// <summary>
        /// Кнопка Обзор...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>Позволяет выбрать путь к папке с файлами</remarks>
        private void BrowseFolderPath(object sender, RoutedEventArgs e)
        {
            string pathDirectory;
            using (CommonOpenFileDialog dialogDirectory = new CommonOpenFileDialog { IsFolderPicker = true })
            {
                pathDirectory = dialogDirectory.ShowDialog() == CommonFileDialogResult.Ok ?
                                dialogDirectory.FileName : null;
            }
            FilePathTB.Text = pathDirectory;
        }

        /// <summary>
        /// Проверка значений, вводимых в TextBox.
        /// </summary>
        /// <remarks>Разрешены только цифры</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            if (digitalFilter.IsMatch(e.Text))
                e.Handled = false;
            else
                e.Handled = true;
        }

        /// <summary>
        /// Кнопка Готово
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayModifiedTestReport(object sender, RoutedEventArgs e)
        {
            ReportChanger repChanger = new ReportChanger(GetOrganizationData());
            repChanger.ModifyDocument(ModifiedReportPath);
            TestReportTB.Text = File.ReadAllText(ModifiedReportPath);
            ChangeFilesInFolder.IsEnabled = true;
        }

        /// <summary>
        /// Считать введённую в поля информацию
        /// </summary>
        /// <returns></returns>
        private DataDTO GetOrganizationData()
        {
            ComboBoxItem countryCode = (ComboBoxItem)CountryCB.SelectedItem;
            StateProvince regionCode = (StateProvince)RegionCB.SelectedItem;
            
            DataDTO dto = new DataDTO
            {
                FullName = FullNameTB.Text,
                ShortName = ShortNameTB.Text,
                INN = InnTB.Text,
                KPP = KppTB.Text,
                Country = countryCode.Tag.ToString(),
                RegionCode = regionCode.Code,
                ClientRegId = ClientRegIdTB.Text,
                JuridicalAddress = AddressDescriptionDB.Text,
            };
            return dto;
        }

        /// <summary>
        /// Изменить отчёты в папке назначения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdjustSettingsToFiles(object sender, RoutedEventArgs e)
        {
            ReportChanger repChanger = new ReportChanger(GetOrganizationData());
            
            if (FilePathTB.Text != "")
            {
                ReportsMetaData md = new ReportsMetaData();
                int fileNum = md.CountReportsInFolder(FilePathTB.Text);
                repChanger.ModifyDocumentsInFolder(FilePathTB.Text);
                MessageBox.Show($"Успешно изменено {fileNum} файлов!", "Успех", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            else
                MessageBox.Show("Укажите путь к папке с файлами для изменения.\nКак правило они находятся в следующих зонах:\n" +
                    "\nСуточные: " + @"C:\Files\Dailies" +
                    "\nПятиминутки: " + @"C:\Files\Snapshots" +
                    "\nСессии: " + @"C:\Files\WayBills"
                                                       ,"Внимние!", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        /// <summary>
        /// Подготовит выпадающий список регионов РФ
        /// </summary>
        private void FillRegionsComboBox()
        {
            StateProvinceList provinceList = new StateProvinceList();
            var regions = provinceList.GetStateProvincesList();
            RegionCB.ItemsSource = regions;
            RegionCB.DisplayMemberPath = "Title";
            RegionCB.SelectedItem = regions[0];
        }

        /// <summary>
        /// Подготовит выпадающий список стран
        /// </summary>
        /// <remarks>По дефолту только Росиия</remarks>
        private void FillCountriesComboBox()
        {
            StateProvinceList list = new StateProvinceList();
            var countries = list.GetCountryList();
            CountryCB.ItemsSource = countries;
            CountryCB.DisplayMemberPath = "Title";
            CountryCB.SelectedItem = countries[0];
        }
    }
}
