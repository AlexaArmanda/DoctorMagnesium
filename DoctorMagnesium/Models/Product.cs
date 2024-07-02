using DoctorMagnesium.Enums;

namespace DoctorMagnesium.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Stock { get; set; }
        public Category Category { get; set; }
        public int? ProducerId { get; set; }
        public Manufacturer? Manufacturers { get; set; }
        public string ImageUrl { get; set; } =string.Empty;
        public List<OrderedItem>? OrderedItems { get; set; }

    }
}
