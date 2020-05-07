using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FindActress.Helpers;
using FindActress.Models;
using FindActress.Views;
using Xamarin.Forms;

namespace FindActress.ViewModels
{
    public class ActressDetailViewModel : BaseViewModel
    {
        public static Actress Selected = new Actress();

        #region Properties

        private Actress _actress;
        public Actress Actress
        {
            get => _actress;
            set
            {
                _actress = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        public ICommand DropDownCommand { get; set; }
        public ICommand SearchCommand { get; set; }

        public ActressDetailViewModel()
        {
            //DropDownCommand = new Command(DropDown);
            SearchCommand = new Command(Search);

            Actress = Selected;
        }

        #region Private Methods

        //private void DropDown(object sender)
        //{
        //    var stackSelected = sender as StackLayout; //Stack selected

        //    var stackContentSelected = stackSelected?.Children.Last() as StackLayout;
        //    if (stackContentSelected != null)
        //        stackContentSelected.IsVisible = !stackContentSelected.IsVisible;

        //    if (stackSelected?.Children.First() is StackLayout stackHeaderSelected)
        //        ((Image)stackHeaderSelected.Children[1]).Source =
        //            stackContentSelected != null && stackContentSelected.IsVisible ? Constants.IconNavigation.IconDown : Constants.IconNavigation.IconRight;
        //}

        private void LoadData()
        {

        }

        private async void Search()
        {
            await Navigation.PushAsync(new FindMoviesPage(Actress.Id));
        }

        #endregion
    }
}
