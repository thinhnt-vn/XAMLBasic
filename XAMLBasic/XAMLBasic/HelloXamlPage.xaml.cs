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

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            valueLable.Text = args.NewValue.ToString("F3");
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            Button clickedButton = (Button)sender;
            await DisplayAlert("Clicked", "Button " + clickedButton.Text + " has been clicked!", "OK");
        }

    }
}
