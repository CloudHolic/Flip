using Flip.Editor.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace Flip.Editor
{
    public class EditorModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<EditorMainView>();
        }
    }
}
