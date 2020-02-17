using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Data
{
    public interface IUserRepository
    {
        Task AddUserAsync(User user, string password);
        Task<User> GetUserByIdAsync(int id);
        Task<User> GetUserByUsernameAsync(string username);
        Task<User> UpdateUserAsync(User user);
        Task ChangePasswordAsync(int id, string currentPasword, string newPassword);
        Task AddToRoleAsync(int userId, string role);
        Task RemoveFromRoleAsync(int userId, string role);
    }
}
