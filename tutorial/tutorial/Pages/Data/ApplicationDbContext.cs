using Microsoft.EntityFrameworkCore;
using tutorial.Pages.Shared;

namespace tutorial.Pages.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Category> categories { get; set; }
    }
}
