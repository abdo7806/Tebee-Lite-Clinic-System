using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Application.Interfaces.Repositories
{
    
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly TebeeLiteDbContext _context;

        public AppointmentRepository(TebeeLiteDbContext context)
        {
            _context = context;
        }

        public async Task<List<Appointment>> GetAllAsync()
        {
            return await _context.Appointments
                    .Include(d => d.BookedByUser)
                    .Include(d => d.Status)
                    .Include(d => d.Patient)
                    .Include(d => d.Doctor.User)
                    .ToListAsync();
        }

        public async Task<Appointment> GetByIdAsync(int id)
        {
            return await _context.Appointments
                    .Include(d => d.BookedByUser)
                    .Include(d => d.Patient)
                    .Include(d => d.Status)
                    .Include(d => d.Doctor.User).FirstOrDefaultAsync(d => d.AppointmentId == id);
        }

        public async Task<Appointment> AddAsync(Appointment appointment)
        {
            await _context.Appointments.AddAsync(appointment);
            await _context.SaveChangesAsync();
            return appointment;
        }

        public async Task<Appointment> UpdateAsync(Appointment appointment)
        {
            _context.Appointments.Update(appointment);
            await _context.SaveChangesAsync();
            return appointment;

        }

        public async Task<bool> DeleteAsync(int id)
        {


            try
            {

                var appointment = await GetByIdAsync(id);

                if (appointment == null)
                {
                    return false; // الطبيب غير موجود
                }


                _context.Appointments.Remove(appointment);





                // حفظ التغييرات
                await _context.SaveChangesAsync();


                return true;
            }
            catch (Exception ex)
            {
                // إلغاء المعاملة في حالة حدوث خطأ
                Console.WriteLine(ex.Message);
                return false;
            }


        }
    }
}
