using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace SharedModule
{
    public class FileDialogService : IFileDialogService
    {
        public FileDialogService()
        {

        }

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
