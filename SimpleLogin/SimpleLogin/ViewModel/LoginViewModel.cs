using SimpleLogin.Model;
using SimpleLogin.Pages;
using SimpleLogin.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleLogin.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {

        private readonly string typeOfRequest = "login";
        #region
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        public INavigation _Navigation { get; set; }
        public string _message { get; set; }

        public Action DisplayInvalidLoginPrompt;

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
                Console.WriteLine("Login Page Set Email " + _email);
                PropertyChanged(this, new PropertyChangedEventArgs(_email));
            }
        }

        private string _password;

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {

                _password = value;
                Console.WriteLine("Login Page Set Password " + _password);
                PropertyChanged(this, new PropertyChangedEventArgs(_password));
            }
        }

        public ICommand SubmitCommand
        {
            protected set; get;

        }

        public LoginViewModel(INavigation _navigation)
        {
            _Navigation = _navigation;
         
            SubmitCommand = new Command(OnSubmitAsync);
            _email = Settings.LastUsedEamil;
            _password = Settings.LastUsedPassword;
        }

        public async void OnSubmitAsync(Object obj)
        {
            Console.WriteLine("Clicked 1");

            if (string.IsNullOrWhiteSpace(_email) || string.IsNullOrWhiteSpace(_password))
            {
                Console.WriteLine("PASS " + _password);
                DisplayInvalidLoginPrompt();
            }
            else
            {
                Settings.LastUsedEamil = _email;
                var credentialItem = new User(_email,_password);
                Console.WriteLine("ciao");
                Console.WriteLine(credentialItem);
                MessageResponse messageResponse = await App._ItemManager.ConvalidateUserAsync(credentialItem, typeOfRequest);
                _message = messageResponse.message;
              if (messageResponse.message.Equals(Message._successfullLogin)){

                    /* var newPage = new InitializePage();
                      {
                          BindingContext = obj;
                      };
                     */
                    await _Navigation.PushAsync(new InitializePage());
                }
                else
                {
                    DisplayInvalidLoginPrompt();
                    CleanEntry();
                }
               

            }
        }

        public void CleanEntry()
        {
            Password = "";
            DisplayInvalidLoginPrompt();
        }

    }
}
