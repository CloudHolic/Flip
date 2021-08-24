using Flip.Core;
using Flip.Core.Interfaces;
using Prism.Commands;
using Prism.Regions;

namespace Flip.Option.ViewModels
{
    public class OptionMainViewViewModel : ViewModelBase
    {
        #region string Title
        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
        #endregion

        public OptionMainViewViewModel(IRegionManager regionManager) : base(regionManager)
        {
            Title = "Option View";
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