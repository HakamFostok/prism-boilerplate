using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace SharedModule
{
    public class FileDialogService : IFileDialogService
    {
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public MessageBoxResult ShowConfirmation(string message)
        {
            return MessageBox.Show(message, "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }

        public string OpenFileDialog(string defaultExt)
        {
            if (string.IsNullOrEmpty(defaultExt))
                throw new ArgumentNullException(nameof(defaultExt));

            OpenFileDialog dialog = new OpenFileDialog
            {
                DefaultExt = defaultExt,
                Multiselect = false
            };
            return dialog.FileName;
        }

        public string[] OpenFilesDialog(string defaultExt)
        {
            if (string.IsNullOrEmpty(defaultExt))
                throw new ArgumentNullException(nameof(defaultExt));

            OpenFileDialog dialog = new OpenFileDialog
            {
                DefaultExt = defaultExt,
                Multiselect = false
            };
            return dialog.FileNames;
        }
    }
}
