using System.Windows;

namespace Core
{
    /// <summary>
    /// Service which provide access to the MessageBox methods and FileDialogs
    /// </summary>
    public interface IMessageBoxService
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

    }
}
