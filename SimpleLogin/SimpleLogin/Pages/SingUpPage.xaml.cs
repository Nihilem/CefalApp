using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLabs.Forms.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SimpleLogin.ViewModel;

namespace SimpleLogin.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SingUpPage : ContentPage
    {
       
    public SingUpPage ()
		{
			InitializeComponent ();
            var _viewModel = new SingUpViewModel(this.Navigation);
            this.BindingContext = _viewModel;
            _viewModel.DisplayInvalidLoginPrompt += () => DisplayAlert("Sorry", _viewModel._message, "ok");

          
            UserPassword.Completed += (Object sender, EventArgs e) =>
            {
                if (string.IsNullOrWhiteSpace(UserPasswordComfirm.Text))
                    UserPasswordComfirm.Focus();
                else
                {
                    
                    _viewModel.PasswordControll.Execute(null);
                }
            };

            UserPasswordComfirm.Completed += (Object sender, EventArgs e) =>
            {
                if (string.IsNullOrWhiteSpace(UserPassword.Text))
                    UserPassword.Focus();
                else
                {

                    _viewModel.PasswordControll.Execute(null);
                }
            };

        }

	}
}