using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLogin.Utils
{
    public class MessageResponse
    {
        [JsonProperty("message")]
        public String message { get; set; }

        public MessageResponse(String message)
        {
            this.message = message;
        }

    }

}
