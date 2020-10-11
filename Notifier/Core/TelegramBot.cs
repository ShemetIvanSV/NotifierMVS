using Notifier.Core.Commands;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Notifier.Core
{
    /// <summary>
    /// Класс реализующий функциональность телеграм бота
    /// </summary>
    public static class TelegramBot
    {
        private static readonly TelegramBotClient _client 
            = new TelegramBotClient(TelegramSettings.Token);

        /// <summary>
        /// Список команд
        /// </summary>
        public static IEnumerable<Command> Commands { get; }

        static TelegramBot()
        {
            //Инициализация команд
            Commands = new List<Command>()
            { 
                new StartCommand(),
                new StopCommand()
            };

            //Вызов комманд
            CommandWorker();
        }

        /// <summary>
        /// Отправка сообщений
        /// </summary>
        /// <param name="message">Текст сообщения</param>
        /// <param name="id">Id получателя</param>
        public static async Task SendMessage(string message, string id)
        {
            await _client.SendTextMessageAsync(id, message);
        }

        /// <summary>
        /// Получение обновлений
        /// </summary>
        private static async void CommandWorker()
        {
            int offset = 0; // отступ по сообщениям

            while (true)
            {
                var updates = await _client.GetUpdatesAsync(offset); 
                
                foreach (var update in updates)
                {
                    var message = update.Message;

                    ExecuteCommands(message);

                    offset = update.Id + 1;
                }
            }
        }
        /// <summary>
        /// Выполнение комманд пользователя
        /// </summary>
        /// <param name="update">Сообщение пользователя </param>
        private static void ExecuteCommands(Message message)
        {
            foreach (var command in Commands)
            {
                if (message.Text == command.Name)
                {
                    command.Execute(message);
                }
            }
        }
    }
}
 