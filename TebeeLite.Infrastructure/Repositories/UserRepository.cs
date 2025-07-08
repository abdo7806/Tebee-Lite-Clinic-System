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
    public class UserRepository : IUserRepository
    {
        private readonly TebeeLiteDbContext _context;

        public UserRepository(TebeeLiteDbContext context)
        {
            _context = context;
        }



        public async Task<List<User>> GetAllAsync()
        {
           return await _context.Users.Include(u => u.Role).ToListAsync();
           // return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetByIdAsync(int userId)
        {
            return await _context.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.UserId == userId);
        }

        public async Task<User?> GetByUsernameAsync(string username)
        {
            return await _context.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<User> AddAsync(User user)
        {
            try
            {
                // نتحقق من ان مافي مستخدم بنفس البريد الاكتروني
                int x = _context.Users.Where(u => u.Username == user.Username).Count();
                if (x == 0)
                {
                    await _context.Users.AddAsync(user);
                    await _context.SaveChangesAsync();
                    return user;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<User> UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user;

        }

        public async Task<bool> DeleteAsync(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user != null)
            {
                try
                {
                    _context.Users.Remove(user);
                    await _context.SaveChangesAsync();
                    return true;

                }
                catch (Exception ex)
                {
                    return false;
                }

            }
            return false;
        }
    }

}
