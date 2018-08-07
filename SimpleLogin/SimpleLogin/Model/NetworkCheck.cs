using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLogin.Model
{
    class NetworkCheck
    {
        public static bool IsInternet()
        {
            if (CrossConnectivity.Current.IsConnected)
                return true;
            return false;
        }
    }
}
