using Notifier.Models;
using System.Linq;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Notifier.Core.Commands
{
    class UnsubscribleCommand : Command
    {

        public UnsubscribleCommand()
        {
            Name = "/stop";
        }

        public override void Execute(Message message)
        {
            var chatId = message?.Chat?.Id;

            var chatType = message?.Chat?.Type;

            var repository = new RecipientRepository();

            var recipientsId = RecipientRepository.Recipients.Select(x => x.Id)
                                                             .Where(x => x == chatId.ToString());

            if(!recipientsId.Any())
            {
                return;
            }

            if (chatType == ChatType.Group)
            {
                if (message.Chat.Title == null)
                    return;

                repository.Remove(message.Chat.Title);
            }
            if (chatType == ChatType.Private)
            {
                if (message.Chat.Username == null)
                    return;

                repository.Remove(message.Chat.Username);
            }
        }
    }
}
