using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Data
{
    public interface IUserRepository
    {
        Task<IdentityResult> AddAsync(User user, string password);
        Task<User> GetAsync(int id);
        Task<User> GetByUsernameAsync(string username);
        Task<IdentityResult> UpdateAsync(User user);
        Task<IdentityResult> ChangePasswordAsync(int id, string currentPasword, string newPassword);
        Task<IdentityResult> AddToRoleAsync(int userId, string role);
        Task<IdentityResult> RemoveFromRoleAsync(int userId, string role);
    }
}
