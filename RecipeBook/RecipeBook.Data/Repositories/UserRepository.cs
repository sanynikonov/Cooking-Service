using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly RecipeBookContext context;
        private readonly DbSet<User> users;
        private readonly UserManager<User> userManager;


        public UserRepository(RecipeBookContext context, UserManager<User> userManager)
        {
            this.context = context;
            this.userManager = userManager;
            users = context.Users;
        }

        public async Task<IdentityResult> AddAsync(User user, string password)
        {
            return await userManager.CreateAsync(user, password);
        }

        public async Task<IdentityResult> UpdateAsync(User user)
        {
            return await userManager.UpdateAsync(user);
        }

        public async Task<IdentityResult> ChangePasswordAsync(int id, string currentPasword, string newPassword)
        {
            var user = await GetAsync(id);
            return await userManager.ChangePasswordAsync(user, currentPasword, newPassword);
        }

        public async Task<User> GetAsync(int id)
        {
            return await users.FindAsync(id);
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            return await userManager.FindByNameAsync(username);
        }

        public async Task<IdentityResult> AddToRoleAsync(int userId, string role)
        {
            var user = await GetAsync(userId);
            return await userManager.AddToRoleAsync(user, role);
        }

        public async Task<IdentityResult> RemoveFromRoleAsync(int userId, string role)
        {
            var user = await GetAsync(userId);
            return await userManager.RemoveFromRoleAsync(user, role);
        }
    }
}
