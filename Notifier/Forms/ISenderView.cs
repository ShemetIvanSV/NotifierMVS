using System;
using System.Collections.Generic;

namespace Notifier.Forms
{
    public interface ISenderView
    {
        event Action SendChanged;

        IEnumerable<object> CheckedRecipients { get; }

        string Message { get; }
    }
}
