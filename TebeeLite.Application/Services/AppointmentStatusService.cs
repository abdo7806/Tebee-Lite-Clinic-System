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
    public class AppointmentStatusService : IAppointmentStateService
    {
        private readonly IAppointmentStatusRepository _appointmentStatusRepository;

        public AppointmentStatusService(IAppointmentStatusRepository appointmentStatusRepository)
        {
            _appointmentStatusRepository = appointmentStatusRepository;

        }

        public async Task<List<AppointmentStatus>> GetAllIAppointmentStatus()
        {
            return await _appointmentStatusRepository.GetAllAsync();
        }
    }
}
