using FindActress.Controls;
using FindActress.Models;
using FindActress.ViewModels;
using Xamarin.Forms.Xaml;

namespace FindActress.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActressDetailPage : CustomContentPage
    {
        private readonly ActressDetailViewModel _viewModel;

        public ActressDetailPage(Actress actress)
        {
            InitializeComponent();

            IsBackButtonEnabled = true;
            PageTitle = "Actress Details";
            IsTitleVisible = true;

            ActressDetailViewModel.Selected = actress;
            _viewModel = new ActressDetailViewModel()
            {
                Navigation = Navigation
            };

            BindingContext = _viewModel;
        }
    }
}