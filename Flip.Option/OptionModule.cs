using Flip.Option.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace Flip.Option
{
    public class OptionModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<OptionMainView>();
        }
    }
}