using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMLBasic
{
    public partial class HelloXamlPage
    {
        public HelloXamlPage()
        {
            InitializeComponent();
        }

        async void OpenXAMLCodePage(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new XamlPlusCodePage());
        }
    }
}
