using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Notely_App.Helpers.BaseViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        

        protected bool SetProperty<T>(ref T backingStoreValue, T value, [CallerMemberName] string propertyName = "",Action onChanged = null)
        {
            if(EqualityComparer<T>.Default.Equals(backingStoreValue, value))
            {
                return false;
            }
            backingStoreValue = value;
            onChanged?.Invoke();
            onPropertyChanged(propertyName);
            return true;

        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void onPropertyChanged([CallerMemberName] string propertyName = "")
        {
            try
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            catch (Exception ex)
            {

            }
        }
    }
}
