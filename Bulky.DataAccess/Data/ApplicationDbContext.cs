using Bulky.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):
            base(options) 
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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
        }
    }
}
