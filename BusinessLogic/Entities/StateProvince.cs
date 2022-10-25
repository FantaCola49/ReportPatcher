namespace ReportPatcher.BusinessLogic.Entities
{
    /// <summary>
    /// Область/Край
    /// </summary>
    internal class StateProvince : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Идентификатор Страны
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Порядок отображения
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Код субъекта согласно конституции
        /// </summary>
        public string Code { get; set; }

        #endregion

        #region Navigation properties

        /// <summary>
        /// Страна
        /// </summary>
        public virtual Country Country { get; set; }

        #endregion
    }
}
