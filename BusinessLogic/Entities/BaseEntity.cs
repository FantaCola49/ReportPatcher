namespace ReportPatcher.BusinessLogic.Entities
{
    /// <summary>
    /// Базовый сущностный тип
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public int Id { get; set; }
    }

    /// <summary>
    /// Дженериковый базовый сущностный тип
    /// </summary>
    /// <typeparam name="TPrimaryKey"></typeparam>
    public abstract class BaseEntity<TPrimaryKey>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public TPrimaryKey Id { get; set; }
    }
}
