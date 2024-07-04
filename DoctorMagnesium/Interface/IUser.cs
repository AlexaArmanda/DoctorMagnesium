using DoctorMagnesium.DTOs.UserDTOs;
using DoctorMagnesium.Models;

namespace DoctorMagnesium.Interface
{
    public interface IUser
    {
        Task<List<User>> GetAllAsync();
        Task<User?> GetByIdAsync(int id);
        Task<User> CreateAsync(User userModel);
        Task<User?> UpdateAsync(int id, UpdateUserRequestDTO userDto);
        Task<User?> DeleteAsync(int id);
        
    }
}
