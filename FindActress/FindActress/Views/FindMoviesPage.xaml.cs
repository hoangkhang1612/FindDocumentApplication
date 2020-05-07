using FindActress.Controls;
using FindActress.Services;
using FindActress.ViewModels;
using Xamarin.Forms.Xaml;

namespace FindActress.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FindMoviesPage : CustomContentPage
    {
        private readonly FindMoviesViewModel _viewModel;
        public FindMoviesPage(string actressId)
        {
            InitializeComponent();

            IsBackButtonEnabled = true;
            PageTitle = "Find movies";
            IsTitleVisible = true;

            FindMoviesViewModel.ActressId = actressId;
            _viewModel = new FindMoviesViewModel(this, App.Container.GetService<IFindMoviesService>())
            {
                Navigation = Navigation
            };

            BindingContext = _viewModel;
        }
    }
}