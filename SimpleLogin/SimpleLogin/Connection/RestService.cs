using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SimpleLogin.Data;
using SimpleLogin.Model;
using SimpleLogin.Utils;


namespace SimpleLogin.Connection
{
    class RestService : IRestService
    {
        private static readonly HttpClient _Client = new HttpClient();
        private ApiResponse messageResponse { get; set; }
        public RestService()
        {

        }

        /*
         * Default uri is setted to login request
         */

        public async Task<ApiResponse> ConvalidateUserAsync(User item, string typeOfRequest)
        {
            
            item.Print();
            if (NetworkCheck.IsInternet())
            {
                _Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var uri = new Uri(string.Format(Constants.RestUrlLogin, string.Empty));

                if (typeOfRequest.Equals("registration"))
                {
                    if (item is Account)
                        item = (Account)item;

                    uri = new Uri(string.Format(Constants.RestUrlRegistration, string.Empty));
                }

                var json = JsonConvert.SerializeObject(item);

                Console.WriteLine("Json " + json);

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
                var responseFromServer = await _Client.SendAsync(request);
                Console.WriteLine("from server " + responseFromServer);
                HttpResponseMessage httpResponse =  (HttpResponseMessage)responseFromServer;

                string res = "";
                using (HttpContent content = responseFromServer.Content)
                {
                    // ... Read the string.
                    Task<string> result = content.ReadAsStringAsync();
                    res = result.Result;
                    Console.WriteLine(res);
                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };
                    if (!string.IsNullOrEmpty(res)) { 
                        messageResponse = JsonConvert.DeserializeObject<ApiResponse>(res, settings);
                        messageResponse._HttpStatus = httpResponse.StatusCode;
                        Console.WriteLine(messageResponse);
                    }
                }

            }
            else
            {
                Console.WriteLine("non connesso");
                messageResponse = new ApiResponse(false,Message._connectionRefused,HttpStatusCode.ServiceUnavailable);

            }

            return messageResponse;

        }

        public Task DeleteTodoItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TodoItem>> RefreshDataAsync()
        {
            throw new NotImplementedException();
        }



        public Task SaveTodoItemAsync(TodoItem item, bool isNewItem)
        {
            throw new NotImplementedException();
        }
    }
}
