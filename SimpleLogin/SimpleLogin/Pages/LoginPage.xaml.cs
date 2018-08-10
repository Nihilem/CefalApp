using SimpleLogin.ViewModel;
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
	public partial class LoginPage : ContentPage
	{

        #region Constructor
        public LoginPage ()
		{

            InitializeComponent();
            var _viewModel = new LoginViewModel(this.Navigation);
            this.BindingContext = _viewModel;
            _viewModel.DisplayInvalidLoginPrompt += () => DisplayAlert("Sorry", "The credentials you supplied are incorrect", "Ok");


        }
        #endregion

    private async void TapGestureRecognizerToSignUp()
        {
            await Navigation.PushAsync(new SingUpPage());
        }

        private async void TapGestureRecognizerToFragmentPage()
        {
            await Navigation.PushAsync(new InitializePage());
        }

    }
}