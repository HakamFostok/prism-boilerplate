using CommonServiceLocator;
using Domain;
using Prism;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SharedModule
{
    public abstract class BaseViewModel : BindableBase, IActiveAware
    {
        protected readonly IRegionManager _regionManager;
        protected readonly IFileDialogService _fileDialogService;
        protected readonly ILogService _logService;
        protected readonly IEventAggregator _aggregator;

        protected BaseViewModel()
        {
            _regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            _fileDialogService = ServiceLocator.Current.GetInstance<IFileDialogService>();
            _logService = ServiceLocator.Current.GetInstance<ILogService>();
            _aggregator = ServiceLocator.Current.GetInstance<IEventAggregator>();
        }

        protected void ShowParameterNullError([CallerMemberName] string callerName = null)
        {
            _fileDialogService.ShowError($"Programming Error, parameter for '{callerName}' method is null");
        }

        protected void HandleException(Exception ex)
        {
            _fileDialogService.ShowError(ex.Message);
            if (!(ex is BusinessException))
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
