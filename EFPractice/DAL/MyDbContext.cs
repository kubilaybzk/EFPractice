using EFPractice.Entities;
using EFPractice.Entities.Mapping;
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
            //Model Mapping kısmını entegre edelim.
            modelBuilder.ApplyConfiguration(new BookMap());
        }
    }
}
