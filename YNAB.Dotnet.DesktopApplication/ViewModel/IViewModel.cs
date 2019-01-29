using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YNAB.Dotnet.DesktopApplication.View;

namespace YNAB.Dotnet.DesktopApplication.ViewModel
{
    public abstract class IViewModel : INotifyPropertyChanged
    {
        public abstract event PropertyChangedEventHandler PropertyChanged;

        public void RaiseError(Exception ex)
        {
            var screen = new ErrorMessage();
            screen.Title = ex.ToString();
            screen.ShowDialog();
        }
    }
}
