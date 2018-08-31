using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLogin.Model
{
    public class Account : User {        
        
       [JsonProperty(PropertyName = "name")]
        private string Name { get; set; }

        [JsonProperty(PropertyName = "lastName")]
        private string LastName { get; set; }

        [JsonProperty(PropertyName = "gender")]
        private string Gender { get; set; }
        
        [JsonProperty(PropertyName = "birthday")]
        private DateTime DateOfBirthday { get; set; }

        [JsonProperty(PropertyName = "identificationRole")]
        private string IdentificationRole { get; set; }


        [JsonProperty(PropertyName = "accessToken")]
        private string AccessToken { get; set; }

    
        public Account(string email, string name, string lastname, string password, string gender, DateTime dateOfBirthday,String identificationRole)
            :base(email,password)
        {
            Name = name;
            LastName  = lastname;
            Password = password;
            Gender = gender;
            DateOfBirthday = dateOfBirthday;
            IdentificationRole = identificationRole;
            Console.WriteLine("create Obj Account");
            Print();
        }

     

        public override void Print()
        {
            base.Print();

            Console.WriteLine("name " + Name);
            Console.WriteLine("lastname " + LastName);

            Console.WriteLine("Gender " + Gender);
            Console.WriteLine("Date " + DateOfBirthday);

            Console.WriteLine("Identification Code for Role " + IdentificationRole);
        }
    }
}
