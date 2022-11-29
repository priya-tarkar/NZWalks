using bookproject.Model;
using Microsoft.EntityFrameworkCore;

namespace bookproject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {


        }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCover> BookCovers { get; set; }
        public DbSet<BookWritter> BookWritter { get; set; }
        public DbSet<Products> Products { get; set; }

    }
}
