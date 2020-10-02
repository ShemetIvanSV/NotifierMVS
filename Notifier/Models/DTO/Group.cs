using System;

namespace Notifier.Models
{
    /// <summary>
    /// Тип получателя - группа
    /// </summary>
    [Serializable]
    class Group : Recipient
    {
        public Group(string channelName, string id) : base(channelName, id) { }
    }
}
