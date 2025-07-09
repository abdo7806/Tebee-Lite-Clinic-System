using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Application.DTOs.Doctor;
using TebeeLite.Application.Interfaces.Repositories;
using TebeeLite.Application.Interfaces.Services;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Application.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IUserRepository _userRepository;

        public DoctorService(IDoctorRepository doctorRepository, IUserRepository uaerRepository)
        {
            _doctorRepository = doctorRepository;
            _userRepository = uaerRepository;
        }

        public async Task<List<DoctorReadDto>> GetAllDoctors()
        {
            var doctors = await _doctorRepository.GetAllAsync();


            return doctors.Select(doctor => new DoctorReadDto
            {
                DoctorId = doctor.DoctorId,
                UserId = doctor.UserId,
                Username = doctor.User.Username,
                FullName = doctor.User.FullName,
                IsActive = doctor.User.IsActive ?? false,
                Specialization = doctor.Specialization,
                YearsOfExperience = doctor.YearsOfExperience,
                LicenseNumber = doctor.LicenseNumber,
                Education = doctor.Education,

                WorkingHours = doctor.WorkingHours,
                Notes = doctor.Notes,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = doctor.UpdatedAt,
            }).ToList();
        }

        public async Task<DoctorReadDto> GetDoctorById(int id)
        {
            var doctor = await _doctorRepository.GetByIdAsync(id);


            return  new DoctorReadDto
            {
                DoctorId = doctor.DoctorId,
                UserId = doctor.UserId,
                Username = doctor.User.Username,
                FullName = doctor.User.FullName,
                IsActive = doctor.User.IsActive ?? false,

                Specialization = doctor.Specialization,
                LicenseNumber = doctor.LicenseNumber,

                YearsOfExperience = doctor.YearsOfExperience,
                WorkingHours = doctor.WorkingHours,
                Education = doctor.Education,

                Notes = doctor.Notes,
                CreatedAt = DateTime.UtcNow,
              //  UpdatedAt = doctor.UpdatedAt,
            };
        }

        public async Task<DoctorReadDto> AddDoctor(DoctorCreateDto doctor)
        {
          /*  var user = new User
            {
                Username = doctor.Username,
                PasswordHash = HashPassword(doctor.PasswordHash),
                FullName = doctor.FullName,
                RoleId = 2,
                IsActive = true
            };

            var createUser = await _userRepository.AddAsync(user);

            if (createUser == null) return null;*/

            var newDactor = new Doctor
            {
                UserId = doctor.UserId,
                Specialization = doctor.Specialization,
                LicenseNumber = doctor.LicenseNumber,
                YearsOfExperience = doctor.YearsOfExperience,
                Education = doctor.Education,
                WorkingHours = doctor.WorkingHours,
                Notes = doctor.Notes,
                CreatedAt = DateTime.Now,

            };

           var respons = await _doctorRepository.AddAsync(newDactor);

            if (respons == null) return null;
            return new DoctorReadDto
            {
                DoctorId = respons.DoctorId,
                UserId = respons.UserId,
                //Username = respons.User.Username,
               // FullName = respons.User.FullName,
                Specialization = respons.Specialization,
                LicenseNumber = respons.LicenseNumber,

                YearsOfExperience = respons.YearsOfExperience,
                WorkingHours = respons.WorkingHours,
                Education = respons.Education,

                Notes = respons.Notes,
                CreatedAt = DateTime.UtcNow,
            };

        }

        public async Task<DoctorReadDto> UpdateDoctor(int id, DoctorUpdateDto doctor)
        {
            var editDoctor = await _doctorRepository.GetByIdAsync(id);
            if (doctor == null) throw new Exception("User not found");

            editDoctor.Specialization = doctor.Specialization;
            editDoctor.LicenseNumber = doctor.LicenseNumber;
            editDoctor.YearsOfExperience = doctor.YearsOfExperience;
            editDoctor.WorkingHours = doctor.WorkingHours;
            editDoctor.Education = doctor.Education;
            editDoctor.Notes = doctor.Notes;
            editDoctor.UpdatedAt = DateTime.Now;

           var respons = await _doctorRepository.UpdateAsync(editDoctor);

            if (respons == null) return null;

            return new DoctorReadDto
            {
                DoctorId = respons.DoctorId,
                UserId = respons.UserId,
                //Username = respons.User.Username,
                // FullName = respons.User.FullName,
                Specialization = respons.Specialization,
                LicenseNumber = respons.LicenseNumber,

                YearsOfExperience = respons.YearsOfExperience,
                WorkingHours = respons.WorkingHours,
                Education = respons.Education,

                Notes = respons.Notes,
                CreatedAt = DateTime.UtcNow,
                 UpdatedAt = doctor.UpdatedAt,
            };
        }

        public async Task<bool> DeleteDoctor(int id)
        {
            return await _doctorRepository.DeleteAsync(id);
        }



    }

}
