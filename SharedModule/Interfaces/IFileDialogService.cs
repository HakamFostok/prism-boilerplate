using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace SharedModule
{
    /// <summary>
    /// Service which provide access to the MessageBox methods and FileDialogs
    /// </summary>
    public interface IFileDialogService
    {
        /// <summary>
        /// Show error message with MessageBox.
        /// </summary>
        /// <param name="message">The error message to show</param>
        void ShowError(string message);

        /// <summary>
        /// Show confirmation message and get the result from the user.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        MessageBoxResult ShowConfirmation(string message);

        /// <summary>
        /// Open File Dialog and get the name of the file that selected. (return only one file)
        /// </summary>
        /// <returns></returns>
        string OpenFileDialog(string defaultExt);

        /// <summary>
        /// Open File Dialog and get the names of the file that selected. (return multiple files)
        /// </summary>
        /// <returns></returns>
        string[] OpenFilesDialog(string defaultExt);
    }
}
