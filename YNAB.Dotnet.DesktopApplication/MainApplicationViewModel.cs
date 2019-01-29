using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using YNAB.Dotnet.DesktopApplication.View;

namespace YNAB.Dotnet.DesktopApplication
{
    public class MainApplicationViewModel : INotifyPropertyChanged
    {
        #region Constructor(s)

        public MainApplicationViewModel()
        {
            DefaultTitle = "nYNAB Desktop";
            SelectedPage = new AutoUpdater();
        }

        #endregion

        #region Attribute(s)

        public string Title
        {
            get
            {
                return SelectedPage?.Title  + " | " + DefaultTitle ?? _DefaultTitle;
            }
        }

        private string _DefaultTitle;
        public string DefaultTitle
        {
            get { return _DefaultTitle; }
            set
            {
                if (_DefaultTitle != value)
                {
                    _DefaultTitle = value;
                    OnPropertyChanged(nameof(DefaultTitle));
                    OnPropertyChanged(nameof(Title));
                }
            }
        }

        private Page _SelectedPage;
        public Page SelectedPage
        {
            get { return _SelectedPage; }
            set
            {
                if (_SelectedPage != value)
                {
                    _SelectedPage = value;
                    OnPropertyChanged(nameof(SelectedPage));
                    OnPropertyChanged(nameof(Title));
                }
            }
        }

        #endregion

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }

        #endregion
    }
}
