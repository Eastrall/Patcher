using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Patcher.App.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies that a property has changed.
        /// </summary>
        /// <param name="propertyName">Property name.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Set the referenced property value and notify the changes.
        /// </summary>
        /// <typeparam name="T">Property type.</typeparam>
        /// <param name="storage">Storage property.</param>
        /// <param name="value">New property value.</param>
        /// <param name="propertyName">Property name.</param>
        /// <returns>True if the property has been changed; false otherwise.</returns>
        protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            
            return true;
        }
    }
}
