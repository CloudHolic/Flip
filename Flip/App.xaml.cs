using System.Windows;
using Flip.Editor;
using Flip.Option;
using Flip.Play;
using Flip.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace Flip
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<PlayModule>();
            moduleCatalog.AddModule<EditorModule>();
            moduleCatalog.AddModule<OptionModule>();
        }
    }
}
