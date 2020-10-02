using Notifier.Forms;
using Notifier.Models;
using Notifier.Presenters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//-1001123077637
namespace Notifier
{
    public partial class MainForm : Form, IRecipientView, ISenderView
    {
        public event Action AddChanged;
        public event Action RemoveChanged;
        public event Action SendChanged;

        public IEnumerable SelectedRows { get => dataGridView.SelectedRows; }
        public IEnumerable<object> CheckedRecipients { get => GetCheckedRecipients(); }
        public string Message { get => textBoxMessage.Text; }
        public string Id { get => textBoxChannelId.Text; }
        public string RecipientName { get => textBoxChannelName.Text; }
        public bool IsCreateChannel { get => radioButtonCreateChannel.Checked; }
        public bool IsCreateGroup { get => radioButtonCreateGroup.Checked; }
        public bool IsCreatePhone { get => radioButtonCreatePhone.Checked; }

        public void Update(IEnumerable<Recipient> recipients)
        {
            dataGridView.DataSource = recipients;

            checkedListBoxChannel.Items.Clear();
            checkedListBoxGroups.Items.Clear();
            checkedListBoxPhones.Items.Clear();

            foreach (var recipient in recipients)
            {
                if(recipient is Group groupRecipient)
                {
                    checkedListBoxGroups.Items.Add(groupRecipient.Name);
                }
                if (recipient is Phone phoneRecipient)
                {
                    checkedListBoxPhones.Items.Add(phoneRecipient.Name);
                }
                if (recipient is Channel channelRecipient)
                {
                    checkedListBoxChannel.Items.Add(channelRecipient.Name);
                }
            }
        }
        public void ShowMessage(string Message)
        {
            MessageBox.Show(Message);
        }

        public MainForm()
        {
            InitializeComponent();

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                DataPropertyName = "Name",
                HeaderText = "Название канала"
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id",
                HeaderText = "Id канала"
            });

            var presenterRecipient = new PresenterRecipient(new RecipientRepository(),this);
            var presenterSender = new PresenterSender(new RecipientRepository(), this);
        }

        private IEnumerable<object> GetCheckedRecipients()
        {
            var result = new List<object>();

            foreach (var item in checkedListBoxChannel.CheckedItems)
            {
                result.Add(item);
            }

            foreach (var item in checkedListBoxGroups.CheckedItems)
            {
                result.Add(item);
            }

            foreach (var item in checkedListBoxPhones.CheckedItems)
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

        private void ButtonAddChannel_Click(object sender, EventArgs e)
        {
            try
            {
                AddChanged?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", $"{ex.Message}");
            }
        }

        private void ButtonDeleteChannel_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveChanged?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", $"{ex.Message}");
            }
        }
    }
}
