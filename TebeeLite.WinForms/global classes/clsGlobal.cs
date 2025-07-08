using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TebeeLite.Application.DTOs.User;

namespace Hotel.Global_Classes
{
    public class clsGlobal
    {
        public static class CurrentUser
        {
            public static int UserId { get; set; }
            public static string Username { get; set; }
            public static string FullName { get; set; }
           // public static int RoleId { get; set; }
          //  public static UserRoleEnum Role { get; set; }
            public static string RoleName { get; set; }
          //  public static bool IsAdmin => RoleName == "Admin";
        }

    }
}
