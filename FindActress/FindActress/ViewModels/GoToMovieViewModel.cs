using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using FindActress.Views;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace FindActress.ViewModels
{
    class GoToMovieViewModel : BaseViewModel
    {
        private readonly string _siteUrl;

        public ICommand ConfirmCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public GoToMovieViewModel(GoToMoviePopup page, string siteUrl)
        {
            _siteUrl = siteUrl;

            ConfirmCommand = new Command(Confirm);
            CancelCommand = new Command(Cancel);
        }

        #region Private Methods

        private void Confirm()
        {
            var url = new Uri(_siteUrl);
            Device.OpenUri(url);
        }

        private async void Cancel()
        {
            await PopupNavigation.Instance.PopAllAsync();
        }

        #endregion
    }
}
