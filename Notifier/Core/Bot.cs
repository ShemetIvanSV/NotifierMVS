using System.Threading.Tasks;
using Telegram.Bot;

namespace Notifier.Core
{
    public class TelegramBot
    {
        private readonly TelegramBotClient _client;

        public TelegramBot()
        {
            _client = new TelegramBotClient(TelegramSettings.Token);
        }

        public async Task SendMessage(string message, string id)
        {
            await _client.SendTextMessageAsync(id, message);
        }
    }
}
