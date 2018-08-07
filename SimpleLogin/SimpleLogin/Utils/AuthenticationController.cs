using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleLogin.Utils
{
    class AuthenticationController
    {

        /*1) - Utilizzare un minimo di 8 caratteri per la lunghezza della vostra password, l'ideale sarebbe una lunghezza di almeno dieci (10) o dodici (12) caratteri;
          2) - Utilizzare un mix di caratteri alfanumerici, ovvero tutti quei caratteri compresi fra "a" e "z" e fra "0" e "9"
          3) - Utilizzare sia caratteri MAIUSCOLI e minuscoli es: A/a, B/b,...Z/z che tutti quei caratteri considerati "speciali" come, "$ % & ( @ # § = ) , : ; - _ + ^";
         * 
         */

        public static bool PasswordVerify(string pass)
        {

            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            Match match = regex.Match(pass);
            if (match.Success)
                return true;
            return false;

        }

        public static bool EmailControll(string email )
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);        
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
