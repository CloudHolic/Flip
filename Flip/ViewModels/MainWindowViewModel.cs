using System.Windows;
using Prism.Mvvm;

namespace Flip.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public MainWindowViewModel()
        {
            Title = "Flip";
        }
    }
}
