using FindActress.ViewModels;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindActress.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertPopupPage : PopupPage
    {
        private readonly AlertViewModel _viewModel;

        public string Message
        {
            set
            {
                if (_viewModel != null)
                {
                    _viewModel.Message = value;
                }
            }
        }

        public AlertPopupPage()
        {
            InitializeComponent();
            _viewModel = new AlertViewModel();
            BindingContext = _viewModel;
        }

        protected override bool OnBackgroundClicked()
        {
            (Application.Current as App)?.CloseAllPopup();

            return false;
        }
    }
}