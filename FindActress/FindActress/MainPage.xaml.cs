using System.ComponentModel;
using FindActress.Controls;
using FindActress.Services;
using FindActress.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindActress
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : CustomContentPage
    {
        private readonly FindActressViewModel _viewModel;

        public MainPage()
        {
            InitializeComponent();

            IsBackButtonEnabled = false;
            PageTitle = "Dashboard";
            IsTitleVisible = true;

            //_viewModel = new FindActressViewModel(this, App.Container.GetService<IFindActressService>())
            //{
            //    Navigation = Navigation
            //};

            //BindingContext = _viewModel;
        }
    }
}
