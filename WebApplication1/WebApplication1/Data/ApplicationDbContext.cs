﻿using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }
        public DbSet<Book> Books { get; set; }
    }
}

