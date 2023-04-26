using EFPractice.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

namespace EFPractice.DAL
{
    public class MyDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=192.168.16.94;Initial Catalog=EFPractice;User ID=SA;Password=Password123;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Bu şekilde constraint tanımlamaları fluent api ile yapılıyor . 

            modelBuilder.Entity<Book>().HasKey(b => b.BookId); //Burada buranın primary key olduğunu belirtiyoruz.
            
            modelBuilder.Entity<Book>().Property(b => b.Title).IsRequired().HasMaxLength(150); //Burada required bir değer olduğunu ve maxsimum 150 karakter olmasını set ediyoruz.
        }
    }
}
