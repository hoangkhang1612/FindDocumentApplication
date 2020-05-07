using FindActress.Helpers;
using Xamarin.Forms;

namespace FindActress.ViewModels
{
    public class BaseViewModel : BindableBase
    {
        public INavigation Navigation { get; set; }

    }
}
