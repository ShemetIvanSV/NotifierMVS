using Notifier.Forms;
using Notifier.Models;
using Notifier.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Notifier
{
    public partial class MainForm : Form, ISenderView
    {
        public event EventHandler<MessageEventArgs> SendMessageChanged;

        public IEnumerable<string> CheckedRecipients { get => GetCheckedRecipients(); }

        public MainForm()
        {
            InitializeComponent();

            //Инициализация презентера
            var presenterSender = new PresenterSender(this);
        }

        /// <summary>
        /// Обновление списков получателей
        /// </summary>
        /// <param name="recipients">Новый список получателей</param>
        public void UpdateRecipientList(IEnumerable<Recipient> recipients)
        {
            checkedListBoxGroups.Items.Clear();
            checkedListBoxPersons.Items.Clear();

            foreach (var recipient in recipients)
            {
                if (recipient is Group groupRecipient)
                {
                    checkedListBoxGroups.Items.Add(groupRecipient.Name);
                }
                if (recipient is Person phoneRecipient)
                {
                    checkedListBoxPersons.Items.Add(phoneRecipient.Name);
                }
            }
        }

        /// <summary>
        /// Вернуть выбранных пользователем получателей
        /// </summary>
        /// <returns>Выбранные получатели</returns>
        private IEnumerable<string> GetCheckedRecipients()
        {
            var result = new List<string>();

            foreach (var selectedGroup in checkedListBoxGroups.CheckedItems)
            {
                result.Add(selectedGroup.ToString());
            }

            foreach (var selectedPerson in checkedListBoxPersons.CheckedItems)
            {
                result.Add(selectedPerson.ToString());
            }

            return result;
        }

        /// <summary>
        /// Обработчик нажатия кнопки отправки сообщения
        /// </summary>
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMessage.Text))
            {
                MessageBox.Show("Введите текст сообщения");
            }
            if(!CheckedRecipients.Any())
            {
                MessageBox.Show("Выберите хотя бы один тип получателя");
            }

            try
            {
                SendMessageChanged?.Invoke(this, new MessageEventArgs(textBoxMessage.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", $"{ex.Message}");
            }
        }
    }
}
