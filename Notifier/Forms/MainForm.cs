using Notifier.Core;
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
        public event Action SendChanged;

        public IEnumerable<object> CheckedRecipients { get => GetCheckedRecipients(); }

        public string Message { get => textBoxMessage.Text; }

        public MainForm()
        {
            InitializeComponent();
        }

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

        private IEnumerable<object> GetCheckedRecipients()
        {
            var result = new List<object>();

            foreach (var item in checkedListBoxGroups.CheckedItems)
            {
                result.Add(item);
            }

            foreach (var item in checkedListBoxPersons.CheckedItems)
            {
                result.Add(item);
            }
            return result;
        }

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
                SendChanged?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", $"{ex.Message}");
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var repository = new RecipientRepository();
            var presenterSender = new PresenterSender(repository, this);
            RecipientRepository.RecipientsChanged += Repository_RecipientsChanged;
            //Вызов комманд
            await TelegramBot.CommandWorker();
        }

        private void Repository_RecipientsChanged(object sender, RecipientsEventArgs e)
        {
            UpdateRecipientList(e.Recipients);
        }
    }
}
