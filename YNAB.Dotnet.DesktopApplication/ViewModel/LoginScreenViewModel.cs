using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YNAB.Dotnet.DesktopApplication.Helper;

namespace YNAB.Dotnet.DesktopApplication.ViewModel
{
    public class LoginScreenViewModel : IViewModel
    {
        public LoginScreenViewModel()
        {
            _LoginCommand = new RelayCommand(Login);
        }

        #region Attribute(s)

        private string _Username;
        public string Username
        {
            get { return _Username; }
            set
            {
                if (_Username != value)
                {
                    _Username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set
            {
                if (_Password != value)
                {
                    _Password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        #endregion

        #region Command(s)

        void Login(object obj)
        {
            RaiseError(new Exception("NO"));
        }

        private RelayCommand _LoginCommand;
        public RelayCommand LoginCommand
        {
            get
            {
                return _LoginCommand;
            }
            set
            {
                if (_LoginCommand != value)
                {
                    _LoginCommand = value;
                    OnPropertyChanged(nameof(LoginCommand));
                }
            }
        }

        #endregion

        #region IViewModel Implementation

        public override event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }

        #endregion
    }
}
