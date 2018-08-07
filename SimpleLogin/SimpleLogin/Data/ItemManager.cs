using SimpleLogin.Connection;
using SimpleLogin.Model;
using SimpleLogin.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


/*
 * the ItemaManager provides the method to invoke web service operations  
 * 
*/

namespace SimpleLogin.Data
{
    public class ItemManager
    {
        IRestService _IRestService;

        public ItemManager(IRestService IRestService)
        {
            _IRestService = IRestService;
        }

        public Task<List<TodoItem>> GetTasksAsync()
        {
            return _IRestService.RefreshDataAsync();
        }

        public Task SaveTaskAsync(TodoItem item, bool isNewItem = false)
        {
            return _IRestService.SaveTodoItemAsync(item, isNewItem);
        }

        public Task DeleteTaskAsync(TodoItem item)
        {
            return _IRestService.DeleteTodoItemAsync(item.Identification);
        }

        public Task<MessageResponse> ConvalidateUserAsync(User item, string typeOfRequest)
        {
            return  _IRestService.ConvalidateUserAsync(item, typeOfRequest);
        }


    }
}
