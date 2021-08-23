using Flip.Core;
using Flip.Play.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Flip.Play
{
    public class PlayModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RequestNavigate(RegionNames.EditRegion, nameof(PlayerMainView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<PlayerMainView>();
        }
    }
}