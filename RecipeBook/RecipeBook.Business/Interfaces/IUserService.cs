using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Business
{
    public interface IUserService
    {
        Task AddAsync(UserDTO user);
        Task<UserDTO> GetAsync(int id);
        Task<UserDTO> GetByUsernameAsync(string username);
        Task UpdateAsync(UserDTO user);
        Task ChangePasswordAsync(int id, string currentPasword, string newPassword);
    }
}
