using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace database_connection.Models
{
    public partial class customerContext : DbContext
    {
        public customerContext()
        {
        }

        public customerContext(DbContextOptions<customerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customerdetail> Customerdetails { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=CJHLT-1625\\SQLEXPRESS;Initial Catalog=customer;Encrypt=False;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customerdetail>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__customer__9725F2C6AFCD0BE8");

                entity.ToTable("customerdetails");

                entity.Property(e => e.CustId)
                    .ValueGeneratedNever()
                    .HasColumnName("custId");

                entity.Property(e => e.Custaddress)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("custaddress");

                entity.Property(e => e.Custgender)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("custgender");

                entity.Property(e => e.Custname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("custname");

                entity.Property(e => e.Custphone).HasColumnName("custphone");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Class).HasColumnName("class");

                entity.Property(e => e.Country)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.FavouriteColor)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("favourite_color");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Subject)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("subject");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
