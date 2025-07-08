using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TebeeLite.Application.DTOs.User
{
    public class UserCreateDto
    {
        public string Username { get; set; }
        public string Password { get; set; }  // Raw password, to be hashed
        public string FullName { get; set; }
        public int RoleId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public UserRoleEnum Role { get; set; }

    }

}
