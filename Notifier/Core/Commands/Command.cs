using Telegram.Bot.Types;

namespace Notifier.Core.Commands
{
    /// <summary>
    /// Комманды телеграм бота
    /// </summary>
    public abstract class Command
    {
        public string Name { get; set; }
        public abstract void Execute(Message message);
    }
}
