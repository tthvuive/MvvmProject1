using MvvmProject1.Commands;
using System.Windows.Input;

namespace MvvmProject1.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _SelectViewModel;
        public ViewModelBase SelectViewModel
        {
            get { return _SelectViewModel; }
            set 
            {
                _SelectViewModel = value; 
                OnPropertyChanged(nameof(SelectViewModel));
            }
        }

        public ICommand UpdateViewCommand { get; set; }
        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }

    }
}
