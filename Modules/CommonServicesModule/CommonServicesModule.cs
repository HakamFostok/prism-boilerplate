using Core;
using NLog;
using Prism.Ioc;
using Prism.Modularity;

namespace SharedModule
{
    public class CommonServicesModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            LogManager.LoadConfiguration("nlog.config");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageBoxService, MessageBoxService>();
            containerRegistry.RegisterSingleton<IFileDialogService, FileDialogService>();
            containerRegistry.RegisterSingleton<ILogService, LogService>();
        }
    }
}
