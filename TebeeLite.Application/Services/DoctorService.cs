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
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task<List<Doctor>> GetAllDoctors()
        {
            return await _doctorRepository.GetAllAsync();
        }

        public async Task<Doctor> GetDoctorById(int id)
        {
            return await _doctorRepository.GetByIdAsync(id);
        }

        public async Task AddDoctor(Doctor doctor)
        {
            await _doctorRepository.AddAsync(doctor);
        }

        public async Task UpdateDoctor(Doctor doctor)
        {
            await _doctorRepository.UpdateAsync(doctor);
        }

        public async Task DeleteDoctor(int id)
        {
            await _doctorRepository.DeleteAsync(id);
        }
    }

}
