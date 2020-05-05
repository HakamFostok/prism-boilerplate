using MainModule.Views;
using Prism.Services.Dialogs;
using System;

namespace MainModule
{
    public static class DialogServiceExtensions
    {
        public static void ShowWindowTest(this IDialogService dialogService, Action<IDialogResult> action)
        {
            dialogService.ShowDialog(nameof(WindowTestView), new DialogParameters(), action);
        }
    }
}
