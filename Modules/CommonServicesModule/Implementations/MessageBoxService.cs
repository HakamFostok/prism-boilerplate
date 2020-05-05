using Core;
using System.Windows;

namespace SharedModule
{
    public class MessageBoxService : IMessageBoxService
    {
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public MessageBoxResult ShowConfirmation(string message)
        {
            return MessageBox.Show(message, "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }
    }
}
