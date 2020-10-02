using Notifier.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Notifier.Forms
{
    public interface IRecipientView
    {
        event Action AddChanged;

        event Action RemoveChanged;

        string RecipientName { get; }

        string Id { get; }

        IEnumerable SelectedRows { get; }

        bool IsCreateChannel { get; }

        bool IsCreateGroup { get; }

        bool IsCreatePhone { get; }

        void Update(IEnumerable<Recipient> recipients);

        void ShowMessage(string message);
    }
}
