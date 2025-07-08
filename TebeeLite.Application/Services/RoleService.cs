using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Application.Interfaces.Repositories;
using TebeeLite.Application.Interfaces.Services;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Application.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }


        public async Task<IReadOnlyList<Role>> GetAllRoles()
        {
            return await _roleRepository.GetAllAsync();
        }
    }
}
