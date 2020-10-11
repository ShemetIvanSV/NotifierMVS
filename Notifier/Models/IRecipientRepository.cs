using System;
using System.Collections.Generic;

namespace Notifier.Models
{
    /// <summary>
    /// Интерфейс репозитория получателей
    /// </summary>
    public interface IRecipientRepository
    {
        /// <summary>
        /// Добавление получателя
        /// </summary>
        /// <param name="recipient">Выбранный получатель</param>
        void Add(Recipient recipient);

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        void Save();

        /// <summary>
        /// Удаление получателя по названию
        /// </summary>
        /// <param name="name">Название получателя для удаления</param>
        void Remove(string name);
    }
}
