using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLogin.Utils
{
    public enum HttpStatusCode
    {
        Continue = 100,
        Switching_Protocols = 101,
        OK = 200,
        Created = 201,
        Accepted = 202,
        Moved_Permanently = 301,
        Bad_Request = 400,
        Not_Found = 404,
        Not_Acceptable = 406,
        HTTP_Version_Not_Supported = 505
    }
}
