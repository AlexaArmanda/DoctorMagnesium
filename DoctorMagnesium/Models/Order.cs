using DoctorMagnesium.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorMagnesium.Models
{
    public class Order
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public string ShippingAddress { get; set; } = string.Empty;
        public string OrderStatus { get; set; } = string.Empty;
        public string PaymentStatus { get; set; } = string.Empty;
        
        public int UserId { get; set; }
        public User? User { get; set; } = null;

        public List<OrderedItem>? OrderedItems { get; set; }

    }
}

