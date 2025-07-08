using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TebeeLite.Application.DTOs.User
{
    public class UserReadDto
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string RoleName { get; set; }   // مأخوذة من جدول Roles
        public bool IsActive { get; set; }
    }
}
