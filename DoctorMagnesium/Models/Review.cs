namespace DoctorMagnesium.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } =string.Empty;
        public int Rating { get; set; }
        public DateTime PostedAt { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int? ProductId { get; set; }
        public Product? Products { get; set; }

    }
}
