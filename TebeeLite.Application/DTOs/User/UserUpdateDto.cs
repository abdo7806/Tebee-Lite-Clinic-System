using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TebeeLite.Application.DTOs.User
{
    public class UserUpdateDto
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        // public int RoleId { get; set; }
        public UserRoleEnum Role { get; set; }

        public bool IsActive { get; set; }
        // اختيارياً: كلمة المرور إذا تريد تعديلها
       // public string? NewPassword { get; set; }

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }

}
