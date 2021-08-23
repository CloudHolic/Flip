using Flip.Core;
using Flip.Editor.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Flip.Editor
{
    public class EditorModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RequestNavigate(RegionNames.EditRegion, nameof(EditorMainView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<EditorMainView>();
        }
    }
}
