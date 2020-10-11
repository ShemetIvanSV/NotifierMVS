using Notifier.Models;
using System;
using System.Collections.Generic;

namespace Notifier.Forms
{
    /// <summary>
    /// Интерфейс представления отправителя
    /// </summary>
    public interface ISenderView
    {
        /// <summary>
        /// Событие отправления сообщения
        /// </summary>
        event EventHandler<MessageEventArgs> SendMessageChanged;

        /// <summary>
        /// Обновление списков получателей
        /// </summary>
        /// <param name="recipients">Новый список получателей</param>
        void UpdateRecipientList(IEnumerable<Recipient> recipients);

        /// <summary>
        /// Выбранные получатели
        /// </summary>
        IEnumerable<string> CheckedRecipients { get; }
    }
}
