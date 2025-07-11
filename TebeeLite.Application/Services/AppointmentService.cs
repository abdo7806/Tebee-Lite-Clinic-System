using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Application.DTOs.Appointment;
using TebeeLite.Application.DTOs.Doctor;
using TebeeLite.Application.Interfaces.Repositories;
using TebeeLite.Application.Interfaces.Services;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Application.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        
        }

        public async Task<List<AppointmentDto>> GetAllAppointments()
        {
            var appointments = await _appointmentRepository.GetAllAsync();


            return appointments.Select(appointment => new AppointmentDto
            {
                AppointmentId = appointment.AppointmentId,
                PatientId = appointment.PatientId,
                DoctorId = appointment.DoctorId,
                PatientName = appointment.Patient.FullName,
                DoctorName = appointment.Doctor.User.FullName,
                BookedByUserName = appointment.BookedByUser.FullName,
                AppointmentDate = appointment.AppointmentDate.ToShortDateString(),
                AppointmentTime = appointment.AppointmentDate.ToShortTimeString(),
                AppointmentDateTime = appointment.AppointmentDate,

                StatusName = appointment.Status.StatusName,
               // Diagnosis = appointment.Diagnosis,
               // Treatment = appointment.Treatment,
                Notes = appointment.Notes,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = appointment.UpdatedAt,
            }).ToList();
        }

        public async Task<AppointmentDto> GetAppointmentById(int id)
        {
            var appointment = await _appointmentRepository.GetByIdAsync(id);


            return new AppointmentDto
            {
                AppointmentId = appointment.AppointmentId,
                PatientId = appointment.PatientId,
                DoctorId = appointment.DoctorId,
                PatientName = appointment.Patient.FullName,
                DoctorName = appointment.Doctor.User.FullName,
                AppointmentDateTime = appointment.AppointmentDate,

                BookedByUserName = appointment.BookedByUser.FullName,
                AppointmentDate = appointment.AppointmentDate.ToShortDateString(),
                AppointmentTime = appointment.AppointmentDate.ToShortTimeString(),
                StatusName = appointment.Status.StatusName,
                Diagnosis = appointment.Diagnosis,
                Treatment = appointment.Treatment,
                Notes = appointment.Notes,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = appointment.UpdatedAt,
            };
        }

        public async Task<bool> DeleteAppointment(int id)
        {
            return await _appointmentRepository.DeleteAsync(id);
        }

 



        public async Task<AppointmentDto> AddAppointment(CreateAppointment appointmentDto)
        {
            var newAppointment = new Appointment
            {
                PatientId = appointmentDto.PatientId,
                DoctorId = appointmentDto.DoctorId,
                AppointmentDate = appointmentDto.AppointmentDate,
                StatusId = appointmentDto.StatusId,
                Notes = appointmentDto.Notes,
                BookedByUserId = appointmentDto.BookedByUserId,
                CreatedAt = DateTime.Now,

            };

            var respons = await _appointmentRepository.AddAsync(newAppointment);

            if (respons == null) return null;
            newAppointment = await _appointmentRepository.GetByIdAsync(respons.AppointmentId);



            return new AppointmentDto
            {
                AppointmentId = newAppointment.AppointmentId,
                PatientName = newAppointment.Patient.FullName,
                DoctorName = newAppointment.Doctor.User.FullName,
                BookedByUserName = newAppointment.BookedByUser.FullName,
                AppointmentDate = newAppointment.AppointmentDate.ToShortDateString(),
                AppointmentTime = newAppointment.AppointmentDate.ToShortTimeString(),
                AppointmentDateTime = newAppointment.AppointmentDate,
                StatusName = newAppointment.Status.StatusName,
                Diagnosis = newAppointment.Diagnosis,
                Treatment = newAppointment.Treatment,
                Notes = newAppointment.Notes,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = newAppointment.UpdatedAt,
            };

        }

        public async Task<AppointmentDto> UpdateAppointment(int id, CreateAppointment appointmentDto)
        {


            var eeditAppointment = await _appointmentRepository.GetByIdAsync(id);
            if (appointmentDto == null) throw new Exception("User not found");

            eeditAppointment.PatientId = appointmentDto.PatientId;
            eeditAppointment.DoctorId = appointmentDto.DoctorId;
            eeditAppointment.AppointmentDate = appointmentDto.AppointmentDate;
            eeditAppointment.StatusId = appointmentDto.StatusId;
            eeditAppointment.Notes = appointmentDto.Notes;
            eeditAppointment.BookedByUserId = appointmentDto.BookedByUserId;
            eeditAppointment.UpdatedAt = DateTime.Now;

            var respons = await _appointmentRepository.UpdateAsync(eeditAppointment);

            if (respons == null) return null;

            return new AppointmentDto
            {
                AppointmentId = eeditAppointment.AppointmentId,
                 PatientName = eeditAppointment.Patient.FullName,
                DoctorName = eeditAppointment.Doctor.User.FullName,
                  BookedByUserName = eeditAppointment.BookedByUser.FullName,
                AppointmentDate = eeditAppointment.AppointmentDate.ToShortDateString(),
                AppointmentTime = eeditAppointment.AppointmentDate.ToShortTimeString(),
                 StatusName = eeditAppointment.Status.StatusName,
                Diagnosis = eeditAppointment.Diagnosis,
                Treatment = eeditAppointment.Treatment,
                Notes = eeditAppointment.Notes,
                CreatedAt = eeditAppointment.CreatedAt,
                UpdatedAt = eeditAppointment.UpdatedAt,
            };
        }
    }

}