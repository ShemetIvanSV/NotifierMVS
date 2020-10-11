namespace Notifier.Forms
{
    /// <summary>
    /// Аргументы для события отправки сообщения
    /// </summary>
    public class MessageEventArgs
    {
        public string Message { get; }

        public MessageEventArgs(string message)
        {
            Message = message;
        }
    }
}
