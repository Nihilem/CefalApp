using SimpleLogin.Model;
using SimpleLogin.Pages;
using SimpleLogin.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace SimpleLogin.ViewModel
{
   
    public class SingUpViewModel : INotifyPropertyChanged
    {
    
        private readonly string typeOfRequest = "registration";

        public Action DisplayInvalidLoginPrompt;
        #region Paramiter
        public INavigation _Navigation { get; set; }

        public string _message { get; set; }

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                Console.WriteLine("Name " + _name);
                PropertyChanged(this, new PropertyChangedEventArgs(_name));
            }
        }

        private string _lastaname;

        public string LastName
        {
            get
            {
                return _lastaname;
            }
            set
            {
                _lastaname = value;
                Console.WriteLine("Name " + _lastaname);
                PropertyChanged(this, new PropertyChangedEventArgs(_lastaname));
            }
        }

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
                Console.WriteLine("Set Password " + _password);
                PropertyChanged(this, new PropertyChangedEventArgs(_password));
            }
        }

        private string _passwordComfirm;

        public string ComfirmPassword
        {
            get
            {
                return _passwordComfirm;
            }
            set
            {
                _passwordComfirm = value;
                PropertyChanged(this, new PropertyChangedEventArgs(_passwordComfirm));
            }
        }

        private string _gender;
        
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
               
                _gender = value;
                Console.WriteLine(_gender);
                PropertyChanged(this, new PropertyChangedEventArgs(_gender));
            }
        }

        private DateTime _birthday;

        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {

                _birthday = value;
                
                Console.WriteLine("BirthDay "+_birthday.ToString("d"));
                PropertyChanged(this, new PropertyChangedEventArgs(_birthday.ToString("d")));
            }
        }

        private List<String> _TypeOfGender;

        public List<string> TypeOfGender
        {
            get
            {
                return _TypeOfGender;
            }
            
        }

        private readonly String identificationRole = "adminSecretKey";




    public ICommand SubmintSingUpCommand { get; set; }

        public  readonly ICommand PasswordControll;
       

        #endregion
        public event PropertyChangedEventHandler PropertyChanged;

        public SingUpViewModel(INavigation _navigation)
        {
            _Navigation = _navigation;
            SubmintSingUpCommand = new Command(OnSingUp);
            PasswordControll = new Command(OnPasswordControll);  
            Init();
        }

        public void Init()
        {
            _TypeOfGender = new List<string>(new string[] { "female", "male" });
            _message = "Error please Retry";
        }

        public async void OnSingUp(Object obj)
        {

            Console.WriteLine("OnSingUp");
            Console.WriteLine("Set Password " + _password);

            if (string.IsNullOrWhiteSpace(_name) || string.IsNullOrWhiteSpace(_lastaname) || string.IsNullOrWhiteSpace(_password)
                ||string.IsNullOrWhiteSpace(_gender) || string.IsNullOrWhiteSpace(_email))
            {
                Console.WriteLine("empty element");
                _message = Message._compileAllElements;
                DisplayInvalidLoginPrompt();
            }
            else
            {
                /*Email and Password Controll
                 */
                if (AuthenticationController.EmailControll(_email))
                {
                   
                    Account account = new Account(_email, _name, _lastaname, _password, _gender, _birthday
                        ,identificationRole);
                    ApiResponse messageResponse = await App._ItemManager.ConvalidateUserAsync(account, typeOfRequest);

                    if(!string.IsNullOrEmpty(messageResponse._Message))
                       _message = messageResponse._Message;

                    if (messageResponse._Success)
                    {
                       
                        Settings.LastUsedEamil = _email;
                        Settings.LastUsedPassword = _password;
                        await _Navigation.PushAsync(new LoginPage());
                    }
                    else
                    {
                        DisplayInvalidLoginPrompt();
                        cleanEntry();
                    }
                

                }
                else
                {
                    Console.WriteLine("Email not valid");
                    _message = Message._invalidEmail;
                    DisplayInvalidLoginPrompt();
                }
              
            }
            
        }

        public void OnPasswordControll(Object obj)
        {
            Console.WriteLine("Controll password");
            if (!_password.Equals(_passwordComfirm))
            {
                Password = "";
                ComfirmPassword = "";
                _message = Message._passwordDontMacth;
                DisplayInvalidLoginPrompt();
            }
        }

        public void cleanEntry()
        {
            Password = "";
            ComfirmPassword = "";
            Email = "";  
            DisplayInvalidLoginPrompt();
        }


    }
}
