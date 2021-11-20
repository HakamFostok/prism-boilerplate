using System;

using Prism.Services.Dialogs;

namespace Core;

public class BaseDialogViewModel : BaseViewModel, IDialogAware
{
    public string Title { get; set; }

    public event Action<IDialogResult> RequestClose;

    public virtual void RaiseRequestClose(IDialogResult dialogResult) => RequestClose?.Invoke(dialogResult);

    public virtual bool CanCloseDialog() => true;

    public virtual void OnDialogClosed()
    {

    }

    public virtual void OnDialogOpened(IDialogParameters parameters)
    {

    }
}
