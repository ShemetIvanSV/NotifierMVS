using System;

namespace Notifier.Models
{
    /// <summary>
    /// Тип получателя - телефон
    /// </summary>
    [Serializable]
    class Phone : Recipient
    {
        public Phone(string channelName, string id) : base(channelName, id) { }
    }
}
