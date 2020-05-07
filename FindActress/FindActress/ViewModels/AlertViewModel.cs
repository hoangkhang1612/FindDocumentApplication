using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FindActress.ViewModels
{
    public class AlertViewModel : BaseViewModel
    {
        private string _message;
        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                RaisePropertyChanged();
            }
        }

        private string _confirmTitle;
        public string ConfirmTitle
        {
            get => _confirmTitle;
            set
            {
                _confirmTitle = value;
                RaisePropertyChanged();
            }
        }

        public ICommand ConfirmCommand { get; set; }
        public ICommand ClosePopupCommand { get; private set; }

        public AlertViewModel()
        {
            ConfirmCommand = new Command(Confirm);
            ClosePopupCommand = new Command(ClosePopup);

            Message = string.Empty;
            ConfirmTitle = "OK";
        }

        protected void Confirm()
        {
            (Application.Current as App)?.CloseAllPopup();
        }

        protected void ClosePopup()
        {
            (Application.Current as App)?.CloseAllPopup();
        }
    }
}
