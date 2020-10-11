using Telegram.Bot.Types;

namespace Notifier.Core.Commands
{
    public abstract class Command
    {
        public string Name { get; set; }
        public abstract void Execute(Message message);
    }
}
