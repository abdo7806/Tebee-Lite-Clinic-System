using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Application.DTOs.Auth;
using TebeeLite.Application.Interfaces.Repositories;
using TebeeLite.Application.Interfaces.Services;

namespace TebeeLite.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<LoginResponseDto> LoginAsync(LoginRequestDto request)
        {
            var user = await _userRepository.GetByUsernameAsync(request.Username);

            if (user == null)
            {
                return new LoginResponseDto
                {
                    IsAuthenticated = false,
                    ErrorMessage = "اسم المستخدم أو كلمة المرور خاطئة"
                };
            }

            // تحقق كلمة المرور - لاحقاً استبدلها بالتشفير المناسب
            if (user.PasswordHash != HashPassword(request.Password))
            {
                return new LoginResponseDto
                {
                    IsAuthenticated = false,
                    ErrorMessage = "اسم المستخدم أو كلمة المرور خاطئة"
                };
            }

            return new LoginResponseDto
            {
                UserId = user.UserId,
                Username = user.Username,
                FullName = user.FullName,
                RoleName = user.Role.RoleName,
                IsActive = user?.IsActive ?? false,
                IsAuthenticated = true
            };
        }

        private string HashPassword(string password)
        {
            // استخدم أي خوارزمية، هذا مثال بسيط
            using var sha = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
