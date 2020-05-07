using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindActress.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomPageTemplate : Grid
    {
        public CustomPageTemplate()
        {
            InitializeComponent();
        }
    }
}