using FindActress.Controls;
using FindActress.Services;
using FindActress.ViewModels;
using Xamarin.Forms.Xaml;

namespace FindActress.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FindActressPage : CustomContentPage
    {
        private readonly FindActressViewModel _viewModel;

        public FindActressPage()
        {
            InitializeComponent();

            IsBackButtonEnabled = false;
            PageTitle = "Find Your Actress";
            IsTitleVisible = true;

            _viewModel = new FindActressViewModel(this, App.Container.GetService<IFindActressService>())
            {
                Navigation = Navigation
            };

            BindingContext = _viewModel;
        }
    }
}