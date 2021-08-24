using Flip.Core;
using Flip.Core.Interfaces;
using Prism.Commands;
using Prism.Regions;

namespace Flip.Play.ViewModels
{
    public class PlayerMainViewModel : ViewModelBase
    {
        #region string Title
        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
        #endregion

        public PlayerMainViewModel(IRegionManager regionManager) : base(regionManager)
        {
            Title = "Play View";
        }

        #region BackCommand
        private DelegateCommand _backCommand;
        public DelegateCommand BackCommand => _backCommand ??= new DelegateCommand(ExecuteBackCommand);

        private void ExecuteBackCommand()
        {
            RegionManager.RequestNavigate(Names.MainRegion, Names.MainMenuView);
        }
        #endregion
    }
}