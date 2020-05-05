using Core;
using MainModule.Views;
using Prism.Commands;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MainModule.ViewModels
{
    public class MainRegionViewModel : BaseViewModel
    {
        public ICommand OpenWindowCommand { get; }
        public MainRegionViewModel()
        {
            OpenWindowCommand = new DelegateCommand(OpenWindowCommandExecuted);
        }

        private void OpenWindowCommandExecuted()
        {
            _dialogService.ShowWindowTest(CloseWindowEventHandler);
        }

        private void CloseWindowEventHandler(IDialogResult dialogResult)
        {
        }
    }
}
