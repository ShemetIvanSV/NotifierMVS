using Notifier.Forms;
using Notifier.Models;
using System.Windows.Forms;

namespace Notifier
{
    public class PresenterRecipient
    {
        private IRecipientRepository _recipientRepository;
        private IRecipientView _view;

        public PresenterRecipient(IRecipientRepository recipientRepository, IRecipientView view)
        {
            _recipientRepository = recipientRepository;
            _view = view;
            _view.AddChanged += () => AddRecipient();
            _view.RemoveChanged += () => RemoveRecipient();

            _view.Update(_recipientRepository.Recipients);
            _recipientRepository.RecipientsChanged += _recipientRepository_RecipientsChanged;
        }

        private void _recipientRepository_RecipientsChanged(object sender, RecipientsEventArgs e)
        {
            _view.Update(e.Recipients);
        }

        private void AddRecipient()
        {
            var name = _view.RecipientName;
            var id = _view.Id;

            if(_view.IsCreateChannel)
            {
                _recipientRepository.Add(new Channel(name, id));
            }
            else if(_view.IsCreateGroup)
            {
                _recipientRepository.Add(new Group(name, id));
            }
            else if (_view.IsCreatePhone)
            {
                _recipientRepository.Add(new Person(name, id));
            }
            else
            {
                _view.ShowMessage("Выберите тип получателя");
            }

            _view.Update(_recipientRepository.Recipients);
        }

        private void RemoveRecipient()
        {
            foreach (DataGridViewRow selectedRow in _view.SelectedRows)
            {
                var name = selectedRow.Cells["Name"].Value.ToString();

                _recipientRepository.Remove(name);
            }
            _view.Update(_recipientRepository.Recipients);
        }
    }
}
