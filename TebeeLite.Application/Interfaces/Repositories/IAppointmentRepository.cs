using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Application.Interfaces.Repositories
{
    public interface IAppointmentRepository
    {
        Task<List<Appointment>> GetAllAsync();
        Task<Appointment> GetByIdAsync(int id);
        Task<Appointment> AddAsync(Appointment appointment);
        Task<Appointment> UpdateAsync(Appointment appointment);
        Task<bool> DeleteAsync(int id);
    }
}
