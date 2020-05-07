using FindActress.ViewModels;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms.Xaml;

namespace FindActress.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoToMoviePopup : PopupPage
    {
        public GoToMoviePopup(string siteUrl)
        {
            InitializeComponent();

            BindingContext = new GoToMovieViewModel(this, siteUrl);
        }
    }
}