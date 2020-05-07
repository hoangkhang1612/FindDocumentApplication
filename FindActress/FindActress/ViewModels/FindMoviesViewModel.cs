using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using FindActress.Models;
using FindActress.Services;
using FindActress.Views;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace FindActress.ViewModels
{
    public class FindMoviesViewModel : BaseViewModel
    {
        private readonly IFindMoviesService _findMoviesService;
        public static string ActressId = string.Empty;

        #region Properties

        private bool _isMoviesEmpty;
        public bool IsMoviesEmpty
        {
            get => _isMoviesEmpty;
            set
            {
                _isMoviesEmpty = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<Movie> _movieActressList;
        public ObservableCollection<Movie> MovieActressList
        {
            get => _movieActressList;
            set
            {
                _movieActressList = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        public ICommand GoToMovieCommand { get; set; }

        public FindMoviesViewModel(FindMoviesPage page, IFindMoviesService findMoviesService)
        {
            _findMoviesService = findMoviesService;
            GoToMovieCommand = new Command<Movie>(GoToMovie);
            LoadData();
        }

        #region Private Methods

        private async Task LoadData()
        {
            UserDialogs.Instance.ShowLoading("", MaskType.Clear);

            var response = await _findMoviesService.GetMovies(ActressId);

            if (response != null)
            {
                if (response.Count > 0)
                {
                    MovieActressList = new ObservableCollection<Movie>(response.Result);
                    IsMoviesEmpty = false;
                }
                else
                {
                    IsMoviesEmpty = true;
                    await PopupNavigation.Instance.PushAsync(new AlertPopupPage
                    {
                        Message = "Movies not found."
                    });
                }
            }
            else
            {
                IsMoviesEmpty = true;
                await PopupNavigation.Instance.PushAsync(new AlertPopupPage
                {
                    Message = "Something went wrong, please try again."
                });

                //UserDialogs.Instance.HideLoading();
            }

            //MovieActressList = new ObservableCollection<Movie>()
            //{
            //    new Movie()
            //    {
            //        Date = DateTime.Now,
            //        ImageUrl = "",
            //        Name = "ABC",
            //        SiteUrl = "https://www.dmm.co.jp/digital/videoa/-/detail/=/cid=ssni00516/"
            //    }
            //};

            UserDialogs.Instance.HideLoading();
        }

        private void GoToMovie(Movie movie)
        {
            PopupNavigation.Instance.PushAsync(new GoToMoviePopup(movie.SiteUrl));
            //var url = new Uri(movie.SiteUrl);
            //Device.OpenUri(url);
        }
        #endregion
    }
}
