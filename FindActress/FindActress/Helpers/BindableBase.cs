using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using FindActress.Annotations;

namespace FindActress.Helpers
{
    public class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Set the property and notify the result whether the value can not be set or not.
        /// </summary>
        /// <returns>True if the value was changed, false if value can not be set.</returns>
        /// <typeparam name="T"></typeparam>
        /// <param name="storage"></param>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
        /// <param name="onChanged"></param>
        /// <param name="validateValue"></param>
        protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = "", Action onChanged = null, Func<T, T, bool> validateValue = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value)) return false;

            if (validateValue != null && !validateValue(storage, value)) return false;

            storage = value;

            onChanged?.Invoke();

            RaisePropertyChanged(propertyName);

            return true;
        }

        /// <summary>
        ///     Raises the PropertyChanged event.
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
