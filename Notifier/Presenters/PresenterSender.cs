using Notifier.Core;
using Notifier.Forms;
using Notifier.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Notifier.Presenters
{
    public class PresenterSender
    {
        private ISenderView _view;
        private IRecipientRepository _recipientRepository;

        public PresenterSender(IRecipientRepository recipientRepository, ISenderView view)
        {
            _view = view;
            _view.SendChanged += ()=> SendMessage();
            _recipientRepository = recipientRepository;
            _view.UpdateRecipientList(RecipientRepository.Recipients);
        }

        private async void SendMessage()
        {
            var listId = new List<string>();

            foreach (var resipientName in _view.CheckedRecipients)
            {
                listId.Add(RecipientRepository.Recipients.Where(c => c.Name == resipientName.ToString())
                                .Select(s => s.Id).FirstOrDefault());
            }

            foreach (var id in listId)
            {
                await TelegramBot.SendMessage(_view.Message, id);
            }
        }
    }
}
