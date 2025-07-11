using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Application.DTOs.Appointment;

namespace TebeeLite.Application.Interfaces.Services
{
    public interface IAppointmentService
    {
        Task<List<AppointmentDto>> GetAllAppointments();
        Task<AppointmentDto?> GetAppointmentById(int id);
        Task<AppointmentDto> AddAppointment(CreateAppointment appointmentDto);
        Task<AppointmentDto> UpdateAppointment(int id, CreateAppointment appointmentDto);
        Task<bool> DeleteAppointment(int id);
    }
}
