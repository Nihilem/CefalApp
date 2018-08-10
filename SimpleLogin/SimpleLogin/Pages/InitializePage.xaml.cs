using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleLogin.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InitializePage : ContentPage
    {
        public InitializePage ()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizerToFragmentPage1()
        {
            await Navigation.PushAsync(new Page1());
        }
        private async void TapGestureRecognizerToFragmentPage2()
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void TapGestureRecognizerToFragmentPage3()
        {
            await Navigation.PushAsync(new Page3());
        }
        private async void TapGestureRecognizerToFragmentPage4()
        {
            await Navigation.PushAsync(new Page4());

        }
    }
}