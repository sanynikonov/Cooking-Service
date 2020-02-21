using AutoMapper;
using RecipeBook.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Business
{
    public class UserService : Service, IUserService
    {
        public UserService(IMapper mapper, IUnitOfWork unit) : base(mapper, unit)
        {
        }

        public async Task AddAsync(UserDTO userDTO)
        {
            var user = mapper.Map<User>(userDTO);
            await unit.UserRepository.AddAsync(user, userDTO.Password);
            await unit.SaveChangesAsync();
        }

        public async Task ChangePasswordAsync(int id, string currentPasword, string newPassword)
        {
            await unit.UserRepository.ChangePasswordAsync(id, currentPasword, newPassword);
            await unit.SaveChangesAsync();
        }

        public async Task<UserDTO> GetAsync(int id)
        {
            var user = await unit.UserRepository.GetAsync(id);
            return mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> GetByUsernameAsync(string username)
        {
            var user = await unit.UserRepository.GetByUsernameAsync(username);
            return mapper.Map<UserDTO>(user);
        }

        public async Task UpdateAsync(UserDTO userDTO)
        {
            var user = mapper.Map<User>(userDTO);
            await unit.UserRepository.UpdateAsync(user);
            await unit.SaveChangesAsync();
        }
    }
}
