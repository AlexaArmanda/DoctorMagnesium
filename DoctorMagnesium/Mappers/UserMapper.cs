using DoctorMagnesium.DTOs.UserDTOs;
using DoctorMagnesium.Models;

namespace DoctorMagnesium.Mappers
{
    public static class UserMapper
    {
        public static UserDTO ToUserDTO(this User userModel)
        {
            return new UserDTO
            {
                Id = userModel.Id,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Username = userModel.Username,

            };
        }
    }
}
