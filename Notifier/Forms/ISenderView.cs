using Notifier.Models;
using System;
using System.Collections.Generic;

namespace Notifier.Forms
{
    public interface ISenderView
    {
        event Action SendChanged;

        void UpdateRecipientList(IEnumerable<Recipient> recipients);

        IEnumerable<object> CheckedRecipients { get; }

        string Message { get; }
    }
}
