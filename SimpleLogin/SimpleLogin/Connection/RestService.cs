using System;
using System.Collections.Generic;
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

        public RestService()
        {

        }

        /*
         * Default uri is setted to login request
         */

        public async Task<MessageResponse> ConvalidateUserAsync(User item, string typeOfRequest)
        {
            MessageResponse messageResponse = new MessageResponse("");
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


                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
                var responseFromServer = await _Client.SendAsync(request);
                string res = "";
                using (HttpContent content = responseFromServer.Content)
                {
                    // ... Read the string.
                    Task<string> result = content.ReadAsStringAsync();
                    res = result.Result;
                    Console.WriteLine("Response "+res);
                    messageResponse = JsonConvert.DeserializeObject<MessageResponse>(res);
                    Console.WriteLine(messageResponse.message);
                }

            }
            else
            {
                Console.WriteLine("non connesso");
                messageResponse = new MessageResponse(Message._connectionRefused);

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
