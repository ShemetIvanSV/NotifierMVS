using Notifier.Core;
using Notifier.Forms;
using Notifier.Models;
using System.Collections.Generic;
using System.Linq;

namespace Notifier.Presenters
{
    public class PresenterSender
    {
        private readonly ISenderView _view;

        public PresenterSender(ISenderView view)
        {
            _view = view;
            _view.SendMessageChanged += View_SendMessageChanged;
            _view.UpdateRecipientList(RecipientManager.Recipients);
            RecipientManager.RecipientsChanged += Repository_RecipientsChanged;
        }

        private async void View_SendMessageChanged(object sender, MessageEventArgs e)
        {
            var listId = new List<string>();

            foreach (var resipientName in _view.CheckedRecipients)
            {
                listId.Add(RecipientManager.Recipients.Where(c => c.Name == resipientName.ToString())
                                .Select(s => s.Id).FirstOrDefault());
            }

            foreach (var id in listId)
            {
                await TelegramBot.SendMessage(e.Message, id);
            }
        }

        private void Repository_RecipientsChanged(object sender, RecipientsEventArgs e)
        {
            _view.UpdateRecipientList(e.Recipients);
        }
    }
}
