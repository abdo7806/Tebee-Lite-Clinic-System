using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Application.Interfaces.Services
{
    public interface IDoctorService
    {
        Task<List<Doctor>> GetAllDoctors();
        Task<Doctor> GetDoctorById(int id);
        Task AddDoctor(Doctor doctor);
        Task UpdateDoctor(Doctor doctor);
        Task DeleteDoctor(int id);
    }
}
