using Microsoft.EntityFrameworkCore;
using tryweblist.Model;

namespace tryweblist.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {


        }
        public DbSet<Category> Categories { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Title = "priya",
                    DisplayOrder = 1
                },
                new Category
                {
                    Id = 2,
                    Title = "tarkar",
                    DisplayOrder = 2
                }


                );
        }*/

    }
}
