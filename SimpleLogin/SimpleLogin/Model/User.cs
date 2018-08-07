using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SimpleLogin.Model
{
    public class User
    {
        [JsonProperty(PropertyName = "email")]
        public String Email { get; set; }
        [JsonProperty(PropertyName = "password")]
        public String Password { get; set; }

        public User(string email, string password)
          
        {
            this.Email = email;
            this.Password = password;
            
        }

        public virtual void Print()
        {
            Console.WriteLine("email " + Email);
            Console.WriteLine("password " + Password);
        }
    }
}
