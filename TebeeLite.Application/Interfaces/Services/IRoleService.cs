using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Application.Interfaces.Services
{
    public interface IRoleService
    {
        Task<IReadOnlyList<Role>> GetAllRoles();
    }
}
