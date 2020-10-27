﻿using Prism;
using Prism.Events;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Core
{
    public abstract class BaseViewModel : BindableBase, IActiveAware
    {
        // custome interfaces
        protected readonly IMessageBoxService _messageBoxService;
        protected readonly IFileDialogService _fileDialogService;
        protected readonly ILogService _logService;

        // prism interfaces
        protected readonly IDialogService _dialogService;
        protected readonly IRegionManager _regionManager;
        protected readonly IEventAggregator _aggregator;

        protected BaseViewModel()
        {
            _messageBoxService = ContainerLocator.Current.Resolve<IMessageBoxService>();
            _fileDialogService = ContainerLocator.Current.Resolve<IFileDialogService>();
            _logService = ContainerLocator.Current.Resolve<ILogService>();

            _dialogService = ContainerLocator.Current.Resolve<IDialogService>();
            _regionManager = ContainerLocator.Current.Resolve<IRegionManager>();
            _aggregator = ContainerLocator.Current.Resolve<IEventAggregator>();
        }

        protected void ShowParameterNullError([CallerMemberName] string callerName = null)
        {
            _messageBoxService.ShowError($"Programming Error, parameter for '{callerName}' method is null");
        }

        protected void HandleException(Exception ex)
        {
            _messageBoxService.ShowError(ex.Message);
            _logService.LogError(ex.ToString());
        }

        protected void ActivateRegionWithView<T>(string regionName)
        {
            try
            {
                IRegion region = _regionManager.Regions[regionName];
                T view = region.Views.OfType<T>().FirstOrDefault();
                region.Activate(view);
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        #region IActiveAware

        public event EventHandler IsActiveChanged;
        private bool _isActive;

        public bool IsActive
        {
            get => _isActive;
            set
            {
                if (value == _isActive)
                    return;

                _isActive = value;
            }
        }

        #endregion
    }
}
