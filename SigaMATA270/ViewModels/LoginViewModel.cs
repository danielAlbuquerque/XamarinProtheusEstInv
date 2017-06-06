using System.Windows.Input;
using Xamarin.Forms;
using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SigaMATA270.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {

        private string _username;
        public string Username
        {
            get => _username;
            set {
                _username = value;
                OnPropertyChanged();
                LoginCommand.ChangeCanExecute();
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set {
                _password = value;
                OnPropertyChanged();
                LoginCommand.ChangeCanExecute();
            }
        }

        public Command LoginCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel()
        {
            _username = "admin";
            _password = "";
            LoginCommand = new Command(ExecuteLoginCommand, CanExecuteLoginExecuteCommand);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ExecuteLoginCommand()
        {
            
        }

        private Boolean CanExecuteLoginExecuteCommand()
        {
            return !String.IsNullOrEmpty(_username) && !String.IsNullOrEmpty(_password);
        }
    }
}
