using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Application.Interfaces.Services
{
    public interface IPatientService
    {

        Task<List<Patient>> GetAllPatients();
        Task<Patient?> GetPatientById(int id);
        Task<Patient> AddPatient(Patient patient);
        Task<Patient> UpdatePatient(int id, Patient patient);
        Task<bool> DeletePatient(int id);
    }
}
