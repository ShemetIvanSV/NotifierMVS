using Notifier.Models;
using System.Linq;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Notifier.Core.Commands
{
    /// <summary>
    /// Комманда подписки на получение сообщений
    /// </summary>
    class StartCommand : Command
    {
        public StartCommand()
        {
            Name = "/start";
        }

        public override void Execute(Message message)
        {
            var chatId = message?.Chat?.Id;

            var chatType = message?.Chat?.Type;

            var recipientsId = RecipientManager.Recipients.Select(x=>x.Id);

            foreach (var id in recipientsId)
            {
                if (id == chatId.ToString())
                {
                    return;
                }
            }

            if (chatType == ChatType.Group)
            {
                RecipientManager.Add(new Group(message.Chat.Title, chatId.ToString()));
            }
            if (chatType == ChatType.Private)
            {
                RecipientManager.Add(new Person(message.Chat.Username, chatId.ToString()));
            }
        }
    }
}
