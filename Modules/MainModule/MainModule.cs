using Core;
using MainModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace MainModule
{
    public class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            IRegionManager regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(MainRegionView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<WindowTestView>();
        }
    }
}
