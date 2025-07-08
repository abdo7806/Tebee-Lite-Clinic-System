using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Application.DTOs.User;
using TebeeLite.Application.Interfaces.Repositories;
using TebeeLite.Application.Interfaces.Services;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        //private readonly IRoleRepository _roleRepo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
         
        }

        public async Task<List<UserReadDto>> GetAllAsync()
        {
            var users = await _repo.GetAllAsync();
            return users.Select(u => new UserReadDto
            {
                UserId = u.UserId,
                Username = u.Username,
                FullName = u.FullName,
                RoleName = u.Role?.RoleName ?? "",
                IsActive = u?.IsActive ?? false
            }).ToList();
        }

        public async Task<UserReadDto?> GetByIdAsync(int id)
        {
            var user = await _repo.GetByIdAsync(id);
            if (user == null) return null;

            return new UserReadDto
            {
                UserId = user.UserId,
                Username = user.Username,
                FullName = user.FullName,
                RoleName = user.Role?.RoleName ?? "",
                IsActive = user?.IsActive ?? false
            };
        }

        public async Task CreateAsync(UserCreateDto dto)
        {
            var user = new User
            {
                Username = dto.Username,
                PasswordHash = HashPassword(dto.Password),
                FullName = dto.FullName,
                RoleId = (int)dto.Role,
                IsActive = true
            };
            await _repo.AddAsync(user);
        }

        public async Task UpdateAsync(int id, UserUpdateDto dto)
        {
            var user = await _repo.GetByIdAsync(id);
            if (user == null) throw new Exception("User not found");

            user.FullName = dto.FullName;
            user.Username = dto.Username;
            user.RoleId = (int)dto.Role;
            user.IsActive = dto.IsActive;

            if (!string.IsNullOrWhiteSpace(dto.NewPassword))
                user.PasswordHash = HashPassword(dto.NewPassword);

            await _repo.UpdateAsync(user);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repo.DeleteAsync(id);
        }

        private string HashPassword(string password)
        {
            // استخدم أي خوارزمية، هذا مثال بسيط
            using var sha = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public async Task<UserReadDto?> GetByUsernameAsync(string username)
        {
            var user = await _repo.GetByUsernameAsync(username);
            if (user == null) return null;

            return new UserReadDto
            {
                UserId = user.UserId,
                Username = user.Username,
                FullName = user.FullName,
                RoleName = user.Role?.RoleName ?? "",
                IsActive = user?.IsActive ?? false
            };
        }
    }

}
