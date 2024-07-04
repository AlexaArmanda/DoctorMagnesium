using DoctorMagnesium.DTOs.ReviewDTOs;
using DoctorMagnesium.Models;

namespace DoctorMagnesium.Mappers
{
    public static class ReviewMapper
    {
        public static ReviewDTO ToReviewDTO(this Review reviewModel)
        {
            return new ReviewDTO
            {
                Id = reviewModel.Id,
                Title = reviewModel.Title,
                Content = reviewModel.Content,
                Rating = reviewModel.Rating,
                

            };
        }
        public static Review ToStockFromCreateReview(this CreateReviewRequestDTO reviewDto, int userId)
        {
            return new Review
            {
                Title = reviewDto.Title,
                Content = reviewDto.Content,
                Rating = reviewDto.Rating,
                UserId = userId
            };
        }
        public static Review ToReviewFromUpdate(this UpdateReviewRequestDTO reviewDto)
        {
            return new Review
            {
                Title = reviewDto.Title,
                Content = reviewDto.Content,
            };
        }
    }
}
