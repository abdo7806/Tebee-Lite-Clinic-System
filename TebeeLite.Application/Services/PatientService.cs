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
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public async Task<Patient> AddPatient(Patient patient)
        {
            
            return await _patientRepository.AddAsync(patient);
        }

        public async Task<bool> DeletePatient(int id)
        {
            return await _patientRepository.DeleteAsync(id);
        }

        public async Task<List<Patient>> GetAllPatients()
        {
            return await _patientRepository.GetAllAsync();
        }

        public async Task<Patient?> GetPatientById(int id)
        {
            return await _patientRepository.GetByIdAsync(id);
        }

        public async Task<Patient> UpdatePatient(int id, Patient patient)
        {
            var editPatient = await GetPatientById(id);
            if (patient == null) return null;

            editPatient.FullName = patient.FullName;
            editPatient.Dob = patient.Dob;
            editPatient.Gender = patient.Gender;
            editPatient.Phone = patient.Phone;
            editPatient.Email = patient.Email;
            editPatient.Address = patient.Address;
            editPatient.BloodType = patient.BloodType;
            editPatient.Notes = patient.Notes;
            editPatient.CreatedAt = patient.CreatedAt;




            return await _patientRepository.UpdateAsync(editPatient);
        }
    }
}
