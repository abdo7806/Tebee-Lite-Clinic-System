using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Application.Interfaces.Repositories;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Infrastructure.Repositories
{
    public class AppointmentStatusRepository : IAppointmentStatusRepository
    {
        private readonly TebeeLiteDbContext _context;

        public AppointmentStatusRepository(TebeeLiteDbContext context)
        {
            _context = context;
        }
        public async Task<List<AppointmentStatus>> GetAllAsync()
        {
            return _context.AppointmentStatuses.ToList();
        }
    }
}
