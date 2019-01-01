using NavigationWpfMVVMSkeleton.Commands;

using System.Windows.Input;

namespace NavigationWpfMVVMSkeleton.ViewModels
{
    class Page3ViewModel : BaseViewModel
    {
        public ICommand NavigateToLogin{ get; set; }
        private object selectedViewModel;
        public object SelectedViewModel
        {
            get { return selectedViewModel; }
            set
            {
                selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public Page3ViewModel()
        {
            NavigateToLogin = new NavigationCommand(NavigateToMain);
        }
        private void NavigateToMain(object obj)
        {
            SelectedViewModel = new LoginViewModel();
        }
    }
}
