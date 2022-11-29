using Microsoft.EntityFrameworkCore;

namespace WebApplication21.Models
{
    public class ImageDbContext : DbContext
    {
        public ImageDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ImageModel> images { get; set; }
    }
}
