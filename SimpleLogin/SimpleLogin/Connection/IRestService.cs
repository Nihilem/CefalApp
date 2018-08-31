using SimpleLogin.Model;
using SimpleLogin.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogin.Connection
{
    public interface IRestService
    {
        Task<List<TodoItem>> RefreshDataAsync();

        Task SaveTodoItemAsync(TodoItem item, bool isNewItem);

        Task DeleteTodoItemAsync(string id);

        Task<ApiResponse> ConvalidateUserAsync(User item, string typeOfRequest);
    }
}
