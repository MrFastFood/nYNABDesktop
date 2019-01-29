using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YNAB.Dotnet.DesktopApplication.ViewModel
{
    public class AutoUpdaterViewModel : IViewModel
    {
        #region Attribute(s)

        private int _PercentageComplete = 30;
        public int PercentageComplete
        {
            get { return _PercentageComplete; }
            set
            {
                if (_PercentageComplete != value)
                {
                    _PercentageComplete = value;
                    OnPropertyChanged(nameof(PercentageComplete));
                }
            }
        }

        private string _Status = "Sample status text";
        public string Status
        {
            get { return _Status; }
            set
            {
                if (_Status != value)
                {
                    _Status = value;
                    OnPropertyChanged(nameof(Status));
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
