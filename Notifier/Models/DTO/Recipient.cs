using System;

namespace Notifier.Models
{
    /// <summary>
    /// Тип получателя
    /// </summary>
    [Serializable]
    public abstract class Recipient
    {
        public string Name { get;}
        
        public string Id { get;}
        
        public Recipient() { }

        public Recipient(string channelName, string connectionString)
        {
            if (string.IsNullOrWhiteSpace(channelName))
            {
                throw new ArgumentNullException("Наименование получателя не указано", nameof(channelName));
            }
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentNullException("Id получателя не указан", nameof(connectionString));
            }

            Name = channelName;
            Id = connectionString;
        }
    }
}
