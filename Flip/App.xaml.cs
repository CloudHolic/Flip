using System.Windows;
using Flip.Core;
using Flip.Editor;
using Flip.Editor.ViewModels;
using Flip.Editor.Views;
using Flip.Option;
using Flip.Option.ViewModels;
using Flip.Option.Views;
using Flip.Play;
using Flip.Play.ViewModels;
using Flip.Play.Views;
using Flip.ViewModels;
using Flip.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

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
            containerRegistry.RegisterForNavigation<MainMenuView, MainMenuViewModel>();
            containerRegistry.RegisterForNavigation<PlayerMainView, PlayerMainViewModel>();
            containerRegistry.RegisterForNavigation<EditorMainView, EditorMainViewViewModel>();
            containerRegistry.RegisterForNavigation<OptionMainView, OptionMainViewViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<PlayerModule>();
            moduleCatalog.AddModule<EditorModule>();
            moduleCatalog.AddModule<OptionModule>();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            var regionManager = Container.Resolve<IRegionManager>();
            var contentRegion = regionManager.Regions[Names.MainRegion];

            var mainMenuView = Container.Resolve<MainMenuView>();
            contentRegion.Add(mainMenuView);
        }
    }
}
