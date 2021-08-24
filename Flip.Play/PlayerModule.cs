using Flip.Play.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace Flip.Play
{
    public class PlayerModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<PlayerMainView>();
        }
    }
}