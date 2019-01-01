using NavigationWpfMVVMSkeleton.Commands;
using System.Windows.Input;

namespace NavigationWpfMVVMSkeleton.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        public ICommand NavigateToPage3 { get; set; }
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

        public LoginViewModel()
        {
            NavigateToPage3 = new NavigationCommand(NavigateToMain);
        }
        private void NavigateToMain(object obj)
        {
            SelectedViewModel = new Page3ViewModel();
        }
    }
}
