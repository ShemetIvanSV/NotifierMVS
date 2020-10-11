using Notifier.Models;
using System.Linq;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Notifier.Core.Commands
{
    class GetIdCommand : Command
    {
        public GetIdCommand()
        {
            Name = "/start";
        }

        public override void Execute(Message message)
        {
            var chatId = message?.Chat?.Id;

            var chatType = message?.Chat?.Type;

            var repository = new RecipientRepository();

            var recipientsId = RecipientRepository.Recipients.Select(x=>x.Id);

            foreach (var id in recipientsId)
            {
                if (id == chatId.ToString())
                {
                    return;
                }
            }

            if (chatType == ChatType.Group)
            {
                repository.Add(new Group(message.Chat.Title, chatId.ToString()));
            }
            if (chatType == ChatType.Private)
            {
                repository.Add(new Person(message.Chat.Username, chatId.ToString()));
            }
        }
    }
}
