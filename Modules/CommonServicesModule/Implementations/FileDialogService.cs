using Core;
using Microsoft.Win32;
using System;

namespace SharedModule
{
    public class FileDialogService : IFileDialogService
    {
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
