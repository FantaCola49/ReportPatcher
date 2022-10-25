using ReportPatcher.BusinessLogic.Entities;
using System.Collections.Generic;

namespace ReportPatcher.BusinessLogic.ComboBoxData
{
    /// <summary>
    /// Класс для работы с кодами провинций
    /// </summary>
    internal class StateProvinceList
    {
        /// <summary>
        /// Получить полный список провинций РФ
        /// </summary>
        /// <returns></returns>
        public List<StateProvince> GetStateProvincesList()
        {
            var country = GetCountryList()[0];

            #region Области/регионы

            var regionList = new List<StateProvince>
            {
                new StateProvince
                {
                    Title = "Республика Адыгея",
                    Code = "01",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Республика Башкортостан",
                    Code = "02",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Республика Бурятия",
                    Code = "03",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Республика Алтай",
                    Code = "04",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Республика Дагестан",
                    Code = "05",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Республика Ингушетия",
                    Code = "06",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Кабардино-Балкарская Республика",
                    Code = "07",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Республика Калмыкия",
                    Code = "08",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Карачаево-Черкесская Республика",
                    Code = "09",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Республика Карелия",
                    Code = "10",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Республика Коми",
                    Code = "11",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Республика Марий Эл",
                    Code = "12",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Республика Мордовия",
                    Code = "13",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Республика Саха (Якутия)",
                    Code = "14",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Республика Северная Осетия - Алания",
                    Code = "15",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Республика Татарстан",
                    Code = "16",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Республика Тыва",
                    Code = "17",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Удмуртская Республика",
                    Code = "18",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Республика Хакасия",
                    Code = "19",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Чеченская республика",
                    Code = "20",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Чувашская Республика",
                    Code = "21",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Алтайский край",
                    Code = "22",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Краснодарский край",
                    Code = "23",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Красноярский край",
                    Code = "24",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Приморский край",
                    Code = "25",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Ставропольский край",
                    Code = "26",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Хабаровский край",
                    Code = "27",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Амурская область",
                    Code = "28",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Архангельская область",
                    Code = "29",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Астраханская область",
                    Code = "30",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Белгородская область",
                    Code = "31",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Брянская область",
                    Code = "32",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Владимирская область",
                    Code = "33",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Волгоградская область",
                    Code = "34",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Вологодская область",
                    Code = "35",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Воронежская область",
                    Code = "36",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Ивановская область",
                    Code = "37",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Иркутская область",
                    Code = "38",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Калининградская область",
                    Code = "39",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Калужская область",
                    Code = "40",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Камчатский край",
                    Code = "41",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Кемеровская область",
                    Code = "42",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Кировская область",
                    Code = "43",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Костромская область",
                    Code = "44",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Курганская область",
                    Code = "45",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Курская область",
                    Code = "46",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Ленинградская область",
                    Code = "47",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Липецкая область",
                    Code = "48",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Магаданская область",
                    Code = "49",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Московская область",
                    Code = "50",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Мурманская область",
                    Code = "51",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Нижегородская область",
                    Code = "52",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Новгородская область",
                    Code = "53",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Новосибирская область",
                    Code = "54",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Омская область",
                    Code = "55",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Оренбургская область",
                    Code = "56",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Орловская область",
                    Code = "57",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Пензенская область",
                    Code = "58",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Пермский край",
                    Code = "59",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Псковская область",
                    Code = "60",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Ростовская область",
                    Code = "61",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Рязанская область",
                    Code = "62",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Самарская область",
                    Code = "63",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Саратовская область",
                    Code = "64",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Сахалинская область",
                    Code = "65",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Свердловская область",
                    Code = "66",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Смоленская область",
                    Code = "67",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Тамбовская область",
                    Code = "68",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Тверская область",
                    Code = "69",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Томская область",
                    Code = "70",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Тульская область",
                    Code = "71",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Тюменская область",
                    Code = "72",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Ульяновская область",
                    Code = "73",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Челябинская область",
                    Code = "74",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Забайкальский край",
                    Code = "75",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Ярославская область",
                    Code = "76",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Москва",
                    Code = "77",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Санкт-Петербург",
                    Code = "78",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Еврейская автономная область",
                    Code = "79",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Ненецкий автономный округ",
                    Code = "83",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Ханты-Мансийский АО",
                    Code = "86",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Чукотский автономный округ",
                    Code = "87",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Ямало-Ненецкий автономный округ",
                    Code = "89",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Республика Крым",
                    Code = "91",
                    DisplayOrder = 0,
                    CountryId = country.Id
                },
                new StateProvince
                {
                    Title = "Севастополь",
                    Code = "92",
                    DisplayOrder = 0,
                    CountryId = country.Id
                }
            };

            #endregion

            return regionList;
        }

        /// <summary>
        /// Вернёт список стран
        /// </summary>
        /// <remarks>По дефолту РФ</remarks>
        /// <returns></returns>
        public List<Country> GetCountryList()
        {
            var countryList = new List<Country>() 
            {
                new Country()
                {
                    Title = "Россия", 
                    DisplayOrder = 1,
                    ThreeLetterIsoCode = "643",
                    Id = 643
                }
            };

            return countryList;
        }
    }
}
