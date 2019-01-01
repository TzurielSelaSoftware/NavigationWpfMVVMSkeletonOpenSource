using NavigationWpfMVVMSkeleton.Commands;
using System;
using System.Windows.Input;

namespace NavigationWpfMVVMSkeleton.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public ICommand NavigateToLoginProp { get; set; }
        private object selectedViewModel;
        public object SelectedViewModel
        {
            get { return selectedViewModel; }
            set { selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public MainViewModel()
        {
            NavigateToLoginProp = new NavigationCommand(NavigateToLogin);
        }
        private void NavigateToLogin(object obj)
        {
            SelectedViewModel = new LoginViewModel();
        }
    }
}
