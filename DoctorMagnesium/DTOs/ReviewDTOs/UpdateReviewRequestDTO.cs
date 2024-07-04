using System.ComponentModel.DataAnnotations;

namespace DoctorMagnesium.DTOs.ReviewDTOs
{
    public class UpdateReviewRequestDTO
    {
        [Required]
        [MinLength(2, ErrorMessage = "Title must be at least 2 characters")]
        [MaxLength(200, ErrorMessage = "Title cannot be over 200 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(2, ErrorMessage = "Content must be at least 4 characters")]
        [MaxLength(200, ErrorMessage = "Content cannot be over 200 characters")]
        public string Content { get; set; } = string.Empty;
    }
}
