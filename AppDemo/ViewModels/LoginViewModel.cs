using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppDemo.ViewModels
{
    class LoginViewModel : ViewModelBase
    {
        private string _userName;
        private SecureString _password;
        private string _errorMessage;

        public string Username 
        { 
            get => _userName;
            set 
            {
                _userName = value;
                OnPropertyChanged(nameof(Username));
            } 
        }
        public SecureString Password 
        { 
            get => _password;
            set 
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string ErrorMessage 
        { 
            get => _errorMessage;
            set 
            {
                _errorMessage = value;
            } 
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanLoginCommand);
        }

        private bool CanLoginCommand(object obj)
        {
            return true;
        }

        private void ExecuteLoginCommand(object obj)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }
    }
}
