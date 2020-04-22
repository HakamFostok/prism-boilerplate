using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace SharedModule
{
    public interface IFileDialogService
    {
        void ShowError(string message);

        MessageBoxResult ShowConfirmation(string message);
    }
}
