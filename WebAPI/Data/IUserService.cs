using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public interface IUserService
    {
        Task<IList<User>> GetUsersAsync();
        Task<User> AddUserAsync(User newUser);
        Task RemoveUserAsync(int? userId);
        Task<User> UpdateUserAsync(User user);
        Task<User> GetUserAsync(int? id);
        Task<User> ValidateUserAsync(string userName, string password);

    }
}