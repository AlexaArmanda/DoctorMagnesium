using DoctorMagnesium.DTOs.ReviewDTOs;
using DoctorMagnesium.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorMagnesium.Interface
{
    public interface IReview
    {
        Task<List<Review>> GetAllAsync();
        Task<Review> CreateAsync(Review reviewModel);
        Task<Review?> UpdateAsync(int id, Review reviewModel);
        Task<Review?> GetByIdAsync(int id);
        Task<Review?> DeleteAsync(int id);
    }
}


