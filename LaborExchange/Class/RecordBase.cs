using System;

namespace LaborExchange.Class
{
    /// <summary>
    /// Абстрактна основа для всіх записів у системі працевлаштування
    /// </summary>
    public abstract class RecordBase
    {
        /// <summary>
        /// Унікальний ідентифікатор запису
        /// </summary>
        public int RecordId { get; set; }
    }
}