using Microsoft.EntityFrameworkCore;
using DoctorMagnesium.Models;
namespace DoctorMagnesium.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options): base(options)
        {
            

        }

        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OrderedItem> OrderedItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
