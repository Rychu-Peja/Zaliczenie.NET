using asp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektnaASP.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Fantasy", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Scifi", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   Id = 1,
                   Title = "Star Wars",
                   Description = "\"Star Wars\" is a space opera about the battle between the Jedi and the Sith. Centered around characters like Luke Skywalker and Darth Vader, the saga explores themes of family and the eternal struggle between good and evil.",
                   ListPrice =45,
                   Price = 45,
                   Price5 = 40,
                   CategoryId =1,
                   ImageUrl = ""
               },
               new Product
               {
                   Id = 2,
                   Title = "Hobbit",
                   Description = "\"The Hobbit\" is a fantasy novel by J.R.R. Tolkien, following the journey of Bilbo Baggins as he accompanies a group of dwarves on a quest to reclaim their homeland. Filled with magical creatures, epic adventures, and the discovery of a powerful ring, the story sets the stage for the events of \"The Lord of the Rings\" trilogy.",
                   ListPrice = 40,
                   Price = 40,
                   Price5 = 35,
                   CategoryId = 2,
                   ImageUrl = ""
               },
               new Product
               {
                   Id = 3,
                   Title = "Vanish in the Sunset",
                   Description = "\r\n\"Indiana Jones\" is an action-adventure film series created by George Lucas and Steven Spielberg. The stories follow the adventures of Dr. Indiana Jones, an archaeologist and professor, as he travels the globe in pursuit of mystical artifacts. Known for its thrilling action sequences and iconic character, the franchise captures the essence of classic adventure storytelling", 
                   ListPrice = 55,
                   Price = 55,
                   Price5 = 50,
                   CategoryId = 3,
                   ImageUrl = ""

               }
          
               );
        }
    }
}
