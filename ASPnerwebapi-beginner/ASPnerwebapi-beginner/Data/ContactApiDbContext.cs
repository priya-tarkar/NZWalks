using ASPnerwebapi_beginner.Model;
using Microsoft.EntityFrameworkCore;

namespace ASPnerwebapi_beginner.Data
{
    public class ContactApiDbContext:DbContext
    {
        public ContactApiDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Contact> contacts { get; set; }
    }
}
