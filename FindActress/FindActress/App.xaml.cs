using System;
using FindActress.Services;
using FindActress.Views;
using Microsoft.Extensions.DependencyInjection;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindActress
{
    public partial class App : Application
    {
        public static IServiceProvider Container { get; private set; }

        public App()
        {
            InitializeComponent();

            Container = new ServiceCollection()
                .AddScoped<IFindActressService, FindActressService>()
                .AddScoped<IFindMoviesService, FindMoviesService>()
                .BuildServiceProvider();

            MainPage = new NavigationPage(new FindActressPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public async void CloseAllPopup()
        {
            await PopupNavigation.Instance.PopAllAsync();
        }

        public void LoadDashBoard()
        {
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
