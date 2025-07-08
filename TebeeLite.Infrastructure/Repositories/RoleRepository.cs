using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Application.Interfaces.Repositories;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Infrastructure.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly TebeeLiteDbContext _context;

        public RoleRepository(TebeeLiteDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Role>> GetAllAsync()
        {
            return await _context.Roles
                .AsNoTracking()  // تحسين الأداء إذا لم تكن هناك حاجة للتتبع
                .ToListAsync();
        }

    }
}
