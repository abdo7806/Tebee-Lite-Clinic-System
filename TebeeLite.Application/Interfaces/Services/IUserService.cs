using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Application.DTOs.User;

namespace TebeeLite.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<List<UserReadDto>> GetAllAsync();
        Task<UserReadDto?> GetByIdAsync(int id);
        Task<UserReadDto?> GetByUsernameAsync(string username);
        Task CreateAsync(UserCreateDto dto); 
        Task UpdateAsync(int id, UserUpdateDto dto);
        Task<bool> DeleteAsync(int id);
    }

}
