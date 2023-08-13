using Bulky.Models;
<<<<<<< HEAD
=======
using Microsoft.AspNetCore.Identity;
>>>>>>> master
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
<<<<<<< HEAD
    public class ApplicationDbContext : IdentityDbContext
=======
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
>>>>>>> master
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):
            base(options) 
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
<<<<<<< HEAD
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
=======
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

>>>>>>> master
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

<<<<<<< HEAD
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 6,
                    Name = "Test",
                    StreetAddress = "mahfuz 123",
                    City = "Test",
                    State = "Test",
                    PhoneNumber = "Test",
                },
                 new Company
                 {
                     Id = 7,
                     Name = "Test",
                     StreetAddress = "mahfuz 123",
                     City = "Test",
                     State = "Test",
                     PhoneNumber = "Test",
                 },
                 new Company
                 {
                     Id = 8,
                     Name = "Test",
                     StreetAddress = "mahfuz 123",
                     City = "Test",
                     State = "Test",
                     PhoneNumber = "Test",
                 }  
                );
=======
           
>>>>>>> master
        }
    }
}
