using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Application.DTOs.Doctor;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Application.Interfaces.Services
{
    public interface IDoctorService
    {
        
        Task<List<DoctorReadDto>> GetAllDoctors();
        Task<DoctorReadDto?> GetDoctorById(int id);
        Task<DoctorReadDto> AddDoctor( DoctorCreateDto doctor);
        Task<DoctorReadDto> UpdateDoctor(int id, DoctorUpdateDto doctor);
        Task<bool> DeleteDoctor(int id);
    }
}
