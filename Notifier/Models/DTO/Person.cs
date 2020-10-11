using System;

namespace Notifier.Models
{
    /// <summary>
    /// Тип получателя - человек
    /// </summary>
    [Serializable]
    class Person : Recipient
    {
        public Person(string channelName, string id) : base(channelName, id) { }
    }
}
