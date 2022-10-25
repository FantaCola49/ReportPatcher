using System.Collections.Generic;

namespace ReportPatcher.BusinessLogic.Entities
{
    /// <summary>
    /// Страна
    /// </summary>
    internal class Country : BaseEntity
    {
        #region Fields

        private ICollection<StateProvince> _states;

        #endregion

        #region Properties

        /// <summary>
        /// Наименование
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Порядок отображения
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Трехзначный ISO код
        /// </summary>
        public string ThreeLetterIsoCode { get; set; }

        #endregion

        #region Navigation properties

        /// <summary>
        /// Регионы
        /// </summary>
        public virtual ICollection<StateProvince> StateProvinces
        {
            get { return _states ?? (_states = new List<StateProvince>()); }
            protected set { _states = value; }
        }

        #endregion
    }
}
