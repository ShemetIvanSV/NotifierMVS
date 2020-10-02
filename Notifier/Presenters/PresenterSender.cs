using Notifier.Core;
using Notifier.Forms;
using Notifier.Models;
using System.Collections.Generic;
using System.Linq;

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
        }

        private async void SendMessage()
        {
            var bot = new TelegramBot();
            var listId = new List<string>();

            foreach (var resipientName in _view.CheckedRecipients)
            {
                listId.Add(_recipientRepository.Recipients.Where(c => c.Name == resipientName.ToString())
                                .Select(s => s.Id).FirstOrDefault());
            }

            foreach (var id in listId)
            {
                await bot.SendMessage(_view.Message, id);
            }
        }
        
    }
}
