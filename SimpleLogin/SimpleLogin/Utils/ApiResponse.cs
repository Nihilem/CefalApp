using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SimpleLogin.Utils
{
    public class ApiResponse
    {
        [JsonProperty(PropertyName="success")]
        public bool _Success
        {
            get;
            set;
        }
        [JsonProperty(PropertyName = "message")]
        public string _Message
        {
            get;
            set;
        }
        [JsonProperty(PropertyName = "httpStatus")]
        
        public HttpStatusCode _HttpStatus
        {
            get;
            set;
        }
        [JsonProperty(PropertyName = "accessToken")]
        public string _AccessToken;

        public ApiResponse()
        {
        }

        public ApiResponse(bool success, string message, HttpStatusCode code)
        {
            _Success = success;
            _Message = message;
            _HttpStatus = code;
        }

      
    }
}
