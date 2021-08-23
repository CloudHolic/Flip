using Flip.Core;
using Flip.Option.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Flip.Option
{
    public class OptionModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RequestNavigate(RegionNames.EditRegion, nameof(OptionMainView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<OptionMainView>();
        }
    }
}