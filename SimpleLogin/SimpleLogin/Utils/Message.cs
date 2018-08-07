using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLogin.Utils
{
    public static class Message
    {
        public static string _passwordDontMacth = "Passwords do not match";

        public static string _compileAllElements = "Compile All ELement";

        public static string _credentialIncorrect = "The credentials you supplied are incorrect";

        public static string _invalidEmail = "The email entered is not vlaid";
        
        public static string _invalidPassword = $"-Utilizzare un minimo di 8 caratteri;{Environment.NewLine}- almeno un una lettera Maiuscola e un numero;{Environment.NewLine }- almeno un carattere speciale $ % &( @ # § = ) , : ; - _ + ";

        public static string _successfullLogin= "Successfully Operation";

        public static string _connectionRefused = "Connection Refused";


    }
}
