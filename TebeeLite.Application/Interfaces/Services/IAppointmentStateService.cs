using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Application.Services;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Application.Interfaces.Services
{
    public interface IAppointmentStateService
    {
        Task<List<AppointmentStatus>> GetAllIAppointmentStatus();

    }
}
