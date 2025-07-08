using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Infrastructure.Models;


namespace TebeeLite.Application.Interfaces.Repositories
{
    public interface IDoctorRepository
    {
        Task<List<Doctor>> GetAllAsync();
        Task<Doctor> GetByIdAsync(int id);
        Task AddAsync(Doctor doctor);
        Task UpdateAsync(Doctor doctor);
        Task DeleteAsync(int id);
    }
}
