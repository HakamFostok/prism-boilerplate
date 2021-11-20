using System.Windows;

using Core;

namespace SharedModule;

public class MessageBoxService : IMessageBoxService
{
    public void ShowError(string message) => MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

    public MessageBoxResult ShowConfirmation(string message) => MessageBox.Show(message, "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
}
