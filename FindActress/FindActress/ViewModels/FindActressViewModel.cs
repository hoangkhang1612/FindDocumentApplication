using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using FindActress.Models;
using FindActress.Services;
using FindActress.Views;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace FindActress.ViewModels
{
    public class FindActressViewModel : BaseViewModel
    {
        private readonly IFindActressService _findActressService;

        #region Properties

        private string _actressName;
        public string ActressName
        {
            get => _actressName;
            set
            {
                _actressName = value;
                RaisePropertyChanged();
            }
        }

        private bool _isActressEmpty;
        public bool IsActressEmpty
        {
            get => _isActressEmpty;
            set
            {
                _isActressEmpty = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<Actress> _actressNameList;
        public ObservableCollection<Actress> ActressNameList
        {
            get => _actressNameList;
            set
            {
                _actressNameList = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        public ICommand FindActressCommand { get; }
        public ICommand FindMovieCommand { get; }
        public ICommand ActressDetailCommand { get; }
        public ICommand ClearCommand { get; }

        public FindActressViewModel(FindActressPage page, IFindActressService findActressService)
        {
            _findActressService = findActressService;

            FindActressCommand = new Command(FindActress);
            ClearCommand = new Command(Clear);
            //FindMovieCommand = new Command<Actress>(async vm => await FindMovies(vm));
            ActressDetailCommand = new Command<Actress>(async vm => await ActressDetail(vm));

            //client.BaseAddress = new Uri("https://jav-rest-api-htpvmrzjet.now.sh/api/");

            IsActressEmpty = true;
        }

        #region Private Methods

        //const string linkActress = "actress?name={0}";

        //const string linkMovies = "videos/{0}";

        //const string google = "https://www.google.com/search?q={0}";

        public async void FindActress()
        {
            UserDialogs.Instance.ShowLoading("", MaskType.Clear);

            try
            {
                if (ActressName != "")
                {
                    var response = await _findActressService.GetActresses(ActressName);

                    if (response != null)
                    {
                        if (response.Count > 0)
                        {
                            ActressNameList = new ObservableCollection<Actress>(response.Result);
                            IsActressEmpty = false;
                        }
                        else
                        {
                            IsActressEmpty = true;
                            await PopupNavigation.Instance.PushAsync(new AlertPopupPage
                            {
                                Message = "Actress not found."
                            });
                        }
                    }
                    else
                    {
                        IsActressEmpty = true;
                        await PopupNavigation.Instance.PushAsync(new AlertPopupPage
                        {
                            Message = "Something went wrong, please try again."
                        });
                    }

                    UserDialogs.Instance.HideLoading();
                }
            }
            catch (Exception ex)
            {
                await PopupNavigation.Instance.PushAsync(new AlertPopupPage
                {
                    Message = ex.ToString()
                });

                UserDialogs.Instance.HideLoading();
            }

            ActressName = string.Empty;
        }

        //private async Task FindMovies(Actress actress)
        //{
        //    await Navigation.PushAsync(new FindMoviesPage());
        //}
        
        private async Task ActressDetail(Actress actress)
        {
            await Navigation.PushAsync(new ActressDetailPage(actress));
        }

        private async void Clear()
        {
            ActressName = string.Empty;
            ActressNameList = null;
            IsActressEmpty = true;
        }

        #endregion
    }
}
