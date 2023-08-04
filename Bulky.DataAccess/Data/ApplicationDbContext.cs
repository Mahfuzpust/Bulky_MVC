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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.",
                    ISBN = "SWB012345698",
                    ListPrice =99,
                    Price = 90,
                    Price50 = 80,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Fortune ",
                    Author = "Billy ",
                    Description = "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.",
                    ISBN = "SWB012345698",
                    ListPrice = 90,
                    Price = 85,
                    Price50 = 80,
                    Price100 = 80,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = " of Time",
                    Author = "Billy Spark",
                    Description = "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.",
                    ISBN = "SWB012345698",
                    ListPrice = 89,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 80,
                    CategoryId = 3,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 4,
                    Title = "Fortune in Time",
                    Author = "Billy Spark",
                    Description = "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.",
                    ISBN = "SWB012345698",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 80,
                    Price100 = 80,
                    CategoryId = 4,
                    ImageUrl = ""
                }
                );
        }
    }
}
