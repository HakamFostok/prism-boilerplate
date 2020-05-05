using MainModule.Views;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

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
