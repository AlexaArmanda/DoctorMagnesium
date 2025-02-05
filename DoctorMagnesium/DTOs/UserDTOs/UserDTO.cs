﻿using DoctorMagnesium.Models;

namespace DoctorMagnesium.DTOs.UserDTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public List<Review>? Reviews { get; set; }
    }
}
