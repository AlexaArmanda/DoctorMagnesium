using System.ComponentModel.DataAnnotations;

namespace DoctorMagnesium.DTOs.ReviewDTOs
{
    public class CreateReviewRequestDTO
    {
        [Required]
        [MinLength(2, ErrorMessage = "Title must be at least 2 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(10, ErrorMessage = "Content must be at least 10 characters")]
        public string Content { get; set; } = string.Empty;
        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }
      
    }
}
