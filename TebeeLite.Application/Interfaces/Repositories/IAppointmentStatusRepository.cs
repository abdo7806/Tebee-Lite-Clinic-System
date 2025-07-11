using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Application.Interfaces.Repositories
{
    public interface IAppointmentStatusRepository
    {
        Task<List<AppointmentStatus>> GetAllAsync();

    }
}
