using Notifier.Core.Commands;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;

namespace Notifier.Core
{
    public static class TelegramBot
    {
        private static readonly TelegramBotClient _client 
            = new TelegramBotClient(TelegramSettings.Token);

        public static IEnumerable<Command> Commands { get; }

        static TelegramBot()
        {
            //Инициализация команд
            Commands = new List<Command>()
            { 
                new GetIdCommand(),
                new UnsubscribleCommand()
            };
        }

        public static async Task SendMessage(string message, string id)
        {
            await _client.SendTextMessageAsync(id, message);
        }

        public static async Task CommandWorker()
        {
            int offset = 0; // отступ по сообщениям

            while (true)
            {
                var updates = await _client.GetUpdatesAsync(offset); 
                
                foreach (var update in updates)
                {
                    var message = update.Message;

                    foreach (var command in Commands)
                    {
                        if(message.Text == command.Name)
                        {
                            command.Execute(message);
                        }
                    }
                    offset = update.Id + 1;
                }
            }
        }
    }
}
 