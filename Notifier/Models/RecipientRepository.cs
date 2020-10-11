using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Notifier.Models
{
    /// <summary>
    /// Репозиторий получателей
    /// </summary>
    public class RecipientRepository : IRecipientRepository
    {
        /// <summary>
        /// Сериализатор
        /// </summary>
        private BinaryFormatter _formatter;

        public static event EventHandler<RecipientsEventArgs> RecipientsChanged;

        /// <summary>
        /// Инициализация репозитория получателей
        /// </summary>
        public RecipientRepository()
        {
            Recipients = new List<Recipient>();
            _formatter = new BinaryFormatter();
            Select();
        }

        /// <summary>
        /// Список получателей
        /// </summary>
        public static IList<Recipient> Recipients { get; private set; }

        /// <summary>
        /// Удаление получателя по названию
        /// </summary>
        /// <param name="name">Наименование получателя для удаления</param>
        public void Remove(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Получатель для удаления отсутствует", nameof(name));

            var deleteItem = Recipients.Where(x => x.Name == name).First();

            Recipients.Remove(deleteItem);
            Save();
            Select();
        }

        /// <summary>
        /// Добавление получателя
        /// </summary>
        /// <param name="recipient">Выбранный получатель</param>
        public void Add(Recipient recipient)
        {
            var isNotRepeatName = Recipients.All(s => s.Name != recipient.Name);

            if (!isNotRepeatName)
                throw new ArgumentException("Данное имя получателя уже занято", nameof(recipient.Name));

            Recipients.Add(recipient);
            Save();
            Select();
        }

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        public void Save()
        {
            var isRepeatName = Recipients.GroupBy(x => x.Name).Any(g => g.Count() > 1);

            if (isRepeatName)
                throw new ArgumentException("Данное имя получателя уже занято");

            using (var stream = File.Create("Recipient.dat"))
            {
                _formatter.Serialize(stream, Recipients);
            }

            RecipientsChanged?.Invoke(this, new RecipientsEventArgs(Recipients));
        }

        /// <summary>
        /// Выборка всех каналов
        /// </summary>
        private void Select()
        {
            using (Stream stream = new FileStream("Recipient.dat", FileMode.OpenOrCreate))
            {
                if (stream.Length != 0)
                    Recipients = (List<Recipient>)_formatter.Deserialize(stream);
            }
        }
    }
}