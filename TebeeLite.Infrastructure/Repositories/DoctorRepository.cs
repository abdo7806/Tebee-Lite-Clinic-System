using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Application.Interfaces.Repositories;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Infrastructure.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly TebeeLiteDbContext _context;

        public DoctorRepository(TebeeLiteDbContext context)
        {
            _context = context;
        }

        public async Task<List<Doctor>> GetAllAsync()
        {
            return await _context.Doctors.Include(d => d.User).ToListAsync();
        }

        public async Task<Doctor> GetByIdAsync(int id)
        {
            return await _context.Doctors.Include(d => d.User).FirstOrDefaultAsync(d => d.DoctorId == id);
        }

        public async Task<Doctor> AddAsync(Doctor doctor)
        {
            await _context.Doctors.AddAsync(doctor);
            await _context.SaveChangesAsync();
            return doctor;
        }

        public async Task<Doctor> UpdateAsync(Doctor doctor)
        {
            _context.Doctors.Update(doctor);
            await _context.SaveChangesAsync();
            return doctor;

        }

        public async Task<bool> DeleteAsync(int id)
        {

            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {

                    var doctor = await GetByIdAsync(id);

                    if (doctor == null)
                    {
                        return false; // الطبيب غير موجود
                    }

                    var User = doctor.User;
                    if (User == null)
                    {
                        return false; // المستخدم غير موجود
                    }

                    _context.Doctors.Remove(doctor);

                    _context.Users.Remove(User);




                    // حفظ التغييرات
                    await _context.SaveChangesAsync();

                    // تأكيد المعاملة
                    await transaction.CommitAsync();

                    return true;
                }
                catch (Exception ex)
                {
                    // إلغاء المعاملة في حالة حدوث خطأ
                    await transaction.RollbackAsync();
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

        }
    }
}
