using System;

namespace Notifier.Models
{
    /// <summary>
    /// Тип получателя - канал
    /// </summary>
    [Serializable]
    public class Channel : Recipient
    {
        public Channel(string channelName, string id) : base(channelName, id) { }
    }
}
