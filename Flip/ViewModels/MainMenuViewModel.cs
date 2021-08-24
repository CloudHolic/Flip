using System.Windows;
using Flip.Core;
using Flip.Core.Interfaces;
using Prism.Commands;
using Prism.Regions;

namespace Flip.ViewModels
{
    public class MainMenuViewModel : ViewModelBase
    {
        #region string Title
        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
        #endregion

        public MainMenuViewModel(IRegionManager regionManager) : base(regionManager)
        {
            Title = "Main View";
        }

        public override bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        #region PlayCommand
        private DelegateCommand _playCommand;
        public DelegateCommand PlayCommand => _playCommand ??= new DelegateCommand(ExecutePlayCommand);

        private void ExecutePlayCommand()
        {
            RegionManager.RequestNavigate(Names.MainRegion, Names.PlayerMainView);
        }
        #endregion

        #region EditCommand
        private DelegateCommand _editCommand;
        public DelegateCommand EditCommand => _editCommand ??= new DelegateCommand(ExecuteEditCommand);

        private void ExecuteEditCommand()
        {
            RegionManager.RequestNavigate(Names.MainRegion, Names.EditorMainView);
        }
        #endregion

        #region OptionCommand
        private DelegateCommand _optionCommand;
        public DelegateCommand OptionCommand => _optionCommand ??= new DelegateCommand(ExecuteOptionCommand);

        private void ExecuteOptionCommand()
        {
            RegionManager.RequestNavigate(Names.MainRegion, Names.OptionMainView);
        }
        #endregion

        #region ExitCommand
        private DelegateCommand _exitCommand;
        public DelegateCommand ExitCommand => _exitCommand ??= new DelegateCommand(ExecuteExitCommand);

        private static void ExecuteExitCommand()
        {
            Application.Current.Shutdown();
        }
        #endregion
    }
}
