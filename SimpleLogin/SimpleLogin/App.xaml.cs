using SimpleLogin.Connection;
using SimpleLogin.Data;
using SimpleLogin.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace SimpleLogin
{
	public partial class App : Application
	{
        public NavigationPage NavigationPage { get; private set; }
        public static ItemManager _ItemManager;
       
		public App ()
		{
			InitializeComponent();
            _ItemManager = new ItemManager(new RestService());
            MainPage = new NavigationPage(new LoginPage());
		}

        public void SetMainPage(Page newPage)
        {
            MainPage = new NavigationPage(newPage);
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
