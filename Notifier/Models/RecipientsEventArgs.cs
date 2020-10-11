using System;
using System.Collections.Generic;

namespace Notifier.Models
{
    /// <summary>
    /// Аргументы для события изменения коллекции
    /// </summary>
    public class RecipientsEventArgs : EventArgs
    {
        public IList<Recipient> Recipients { get; }

        public RecipientsEventArgs(IList<Recipient> recipients)
        {
            Recipients = recipients;
        }
    }
}
