using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Application.DTOs.User;

namespace TebeeLite.Application.DTOs.Auth
{
    public class LoginResponseDto
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string RoleName { get; set; }
        public UserRoleEnum Role { get; set; }
        public bool IsAuthenticated { get; set; }
        public string ErrorMessage { get; set; } // مثلا "اسم المستخدم أو كلمة المرور خاطئة"


        public bool IsActive { get; set; }
    }
}
