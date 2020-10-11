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

        public Recipient(string name, string id)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Наименование получателя не указано");
            }
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentNullException("Id получателя не указан");
            }

            Name = name;
            Id = id;
        }
    }
}
