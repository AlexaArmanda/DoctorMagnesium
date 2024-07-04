using DoctorMagnesium.Data;
using DoctorMagnesium.DTOs.UserDTOs;
using DoctorMagnesium.Interface;
using DoctorMagnesium.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DoctorMagnesium.Repository
{
    public class UserRepo : IUser
    {
        private readonly ApplicationDbContext _context;
        public UserRepo(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        public Task<User> CreateAsync(User userModel)
        {
            throw new NotImplementedException();
        }

        public Task<User?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllAsync()
        {
            var stocks = _context.Users.Include(c => c.Reviews);
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User?> UpdateAsync(int id, UpdateUserRequestDTO userDto)
        {
            var existingUser = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (existingUser == null)
            {
                return null;
            }
            existingUser.FirstName = userDto.FirstName;
            existingUser.LastName = userDto.LastName;
            existingUser.PhoneNumber = userDto.PhoneNumber;
            existingUser.Username = userDto.Username;


            await _context.SaveChangesAsync();
            return existingUser;
        }
    }
}
